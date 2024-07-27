using eProdaja.eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace eProdaja.Security;

public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    private readonly IKorisnikService _korisnikService;
    public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IKorisnikService korisnikService) : base(options, logger, encoder, clock)
    {
        _korisnikService = korisnikService;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey("Authorization"))
        {
            return AuthenticateResult.Fail("Missing auth header");
        }

        Korisnici user = null;

        try
        {
            var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var creadetialByte = Convert.FromBase64String(authHeader.Parameter);
            var credential = Encoding.UTF8.GetString(creadetialByte).Split(":");
            var username = credential[0];
            var password = credential[1];

            user = await _korisnikService.Loging(username, password);
        }
        catch (Exception)
        {
            return AuthenticateResult.Fail("Incorrect username or password");
            throw;
        }

        if (user == null)
        {
            return AuthenticateResult.Fail("Incorrect username or password");
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme),
            new Claim(ClaimTypes.Name, user.Ime)
        };

        //foreach (var role in user.KorisniciUloges)
        //{
        //    claims.Add(new Claim(ClaimTypes.Role, role.Uloga.Naziv));
        //}

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return AuthenticateResult.Success(ticket);
    }
}
