using eProdaja.eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers;

[ApiController]
[Route("[controller]")]
public class JediniceMjereController : Controller
{
    private readonly IJedinicaMjereServices _jediniceMjereService;
    public JediniceMjereController(IJedinicaMjereServices jediniceMjereService)
    {
        _jediniceMjereService = jediniceMjereService;
    }

    [HttpGet]
    public IEnumerable<JediniceMjere> Index()
    {
        return _jediniceMjereService.Get();
    }

    [HttpGet("{id}")]
    public JediniceMjere GetById(int id)
    {
        return _jediniceMjereService.GetById(id);
    }
}
