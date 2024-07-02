using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;

namespace eProdaja.eProdaja.Services;

public class JedinicaMjereServices : IJedinicaMjereServices
{
    public EProdajaContext _context { get; set; }
    private readonly IMapper _mapper;

    public JedinicaMjereServices(EProdajaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Model.JediniceMjere> Get()
    {
        return _context.JediniceMjeres.ToList().Select(x => _mapper.Map<Model.JediniceMjere>(x)).ToList();
    }

    public Model.JediniceMjere GetById(int id)
    {
        var entity = _context.JediniceMjeres.Find(id);

        return _mapper.Map<Model.JediniceMjere>(entity);
    }
}
