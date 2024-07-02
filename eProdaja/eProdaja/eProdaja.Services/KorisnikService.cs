using AutoMapper;
using eProdaja.Database;

namespace eProdaja.eProdaja.Services;

public class KorisnikService : IKorisnikService
{
    public EProdajaContext _context { get; set; }
    private readonly IMapper _mapper;

    public KorisnikService(EProdajaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<Model.Korisnici> Get()
    {
        return _context.Korisnicis.ToList().Select(x => _mapper.Map<Model.Korisnici>(x)).ToList();
    }
}
