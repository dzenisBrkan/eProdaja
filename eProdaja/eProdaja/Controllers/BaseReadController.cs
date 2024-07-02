using eProdaja.eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseReadController<T> : ControllerBase where T : class
{
    protected readonly IReadService<T> _readService;
    public BaseReadController(IReadService<T> readService)
    {
        _readService = readService;
    }

    [HttpGet]
    public virtual IEnumerable<T> Index()
    {
        return _readService.Get();
    }

    [HttpGet("{id}")]
    public virtual T GetById(int id)
    {
        return _readService.GetById(id);
    }
}
