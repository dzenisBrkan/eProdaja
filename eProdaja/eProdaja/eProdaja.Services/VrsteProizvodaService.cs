using AutoMapper;
using eProdaja.Database;

namespace eProdaja.eProdaja.Services;

public class VrsteProizvodaService : BaseReadService<Model.VrsteProizvodum, Database.VrsteProizvodum, object>, IVrsteProizvodaService
{
    public VrsteProizvodaService(EProdajaContext context, IMapper mapper) : base(context, mapper)
    {}
}
