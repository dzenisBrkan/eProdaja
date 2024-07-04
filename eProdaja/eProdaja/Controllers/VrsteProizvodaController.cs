using eProdaja.eProdaja.Services;
using eProdaja.Model;

namespace eProdaja.Controllers;

public class VrsteProizvodaController : BaseReadController<VrsteProizvodum, object>
{
    public VrsteProizvodaController(IVrsteProizvodaService vrsteProizvodaService)
        :base(vrsteProizvodaService)
    {}
}
