using eProdaja.eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers;

//[ApiController]
//[Route("[controller]")]
public class VrsteProizvodaController : BaseReadController<VrsteProizvodum>
{
    //private readonly IVrsteProizvodaService _vrsteProizvodaService;
    public VrsteProizvodaController(IVrsteProizvodaService vrsteProizvodaService)
        :base(vrsteProizvodaService)
    {
        //_vrsteProizvodaService = vrsteProizvodaService;
    }

    //[HttpGet]
    //public IEnumerable<VrsteProizvodum> Index()
    //{
    //    return _vrsteProizvodaService.Get();
    //}

    //[HttpGet("{id}")]
    //public VrsteProizvodum GetById(int id)
    //{
    //    return _vrsteProizvodaService.GetById(id);
    //}
}
