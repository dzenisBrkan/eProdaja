using eProdaja.eProdaja.Services;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class KorisnikController : ControllerBase
{
    private readonly IKorisnikService _korisnikService;
    public KorisnikController(IKorisnikService korisnikService)
    {
        _korisnikService = korisnikService;
    }

    [HttpGet]
    public IList<Korisnici> Index([FromQuery]KorisniciSearchRequest request)
    {
        return _korisnikService.Get(request);
    }

    [HttpGet("{id}")]
    public Korisnici GetById(int id)
    {
        return _korisnikService.GetById(id);
    }

    [Authorize(Roles = "Administrator")]
    [HttpPost]
    public Korisnici Insert([FromBody] KorisniciInsertRequest request)
    {
        return _korisnikService.Insert(request);
    }

    [Authorize(Roles = "Administrator")]
    [HttpPut("{id}")]
    public Korisnici Update(int id, [FromBody] KorisniciUpdateRequest request)
    {
        return _korisnikService.Update(id,request);
    }
}