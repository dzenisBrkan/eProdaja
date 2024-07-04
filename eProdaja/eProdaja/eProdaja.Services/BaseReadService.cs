using AutoMapper;
using eProdaja.Database;

namespace eProdaja.eProdaja.Services;

public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T : class where TDb : class where TSearch : class
{
    public EProdajaContext _context { get; set; }
    protected readonly IMapper _mapper;

    public BaseReadService(EProdajaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public virtual IEnumerable<T> Get(TSearch search = null)
    {
        var entity = _context.Set<TDb>();
        var list = entity.ToList();

        return _mapper.Map<List<T>>(list);
    }

    public virtual T GetById(int id)
    {
        var set = _context.Set<TDb>();
        var entity = set.Find(id);

        return _mapper.Map<T>(entity);
    }
}
