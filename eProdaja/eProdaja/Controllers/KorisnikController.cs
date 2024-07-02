using eProdaja.eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers;

[ApiController]
[Route("[controller]")]
public class KorisnikController : Controller
{
    private readonly IKorisnikService _korisnikService;
    public KorisnikController(IKorisnikService korisnikService)
    {
        _korisnikService = korisnikService;
    }

    [HttpGet]
    public IList<Korisnici> Index()
    {
        return _korisnikService.Get();
    }
}
