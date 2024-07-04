using AutoMapper;
using eProdaja.Database;

namespace eProdaja.eProdaja.Services;

public class JedinicaMjereServices : BaseReadService<Model.JediniceMjere, Database.JediniceMjere, object>, IJedinicaMjereServices
{
    public JedinicaMjereServices(EProdajaContext context, IMapper mapper)
        : base(context, mapper) 
    {}
}
