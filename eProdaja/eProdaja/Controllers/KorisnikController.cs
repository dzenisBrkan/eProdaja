using eProdaja.eProdaja.Services;
using eProdaja.Model;
using eProdaja.Model.Requests;
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

    [HttpGet("{id}")]
    public Korisnici GetById(int id)
    {
        return _korisnikService.GetById(id);
    }

    [HttpPost]
    public Korisnici Insert([FromBody] KorisniciInsertRequest request)
    {
        return _korisnikService.Insert(request);
    }
}
