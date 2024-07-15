using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Microsoft.EntityFrameworkCore;

namespace eProdaja.eProdaja.Services;

public class ProizvodService : BaseCRUDService<Model.Proizvodi, Database.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, IProizvodService
{
    public ProizvodService(EProdajaContext context, IMapper mapper): base(context, mapper)
    {}

    public override IEnumerable<Model.Proizvodi> Get(ProizvodiSearchObject search = null)
    {
        var entity = _context.Set<Database.Proizvodi>().AsQueryable();

        if (!string.IsNullOrWhiteSpace(search?.Naziv))
        {
            entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
        }
        if (search.JedinicaMjereId.HasValue)
        {
            entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
        }
        if (search.VrstaId.HasValue)
        {
            entity = entity.Where(x => x.VrstaId == search.VrstaId);
        }
        if (search?.IncludeJedinicaMjere == true)
        {
            entity = entity.Include("JedinicaMjere");
        }
        //if (search?.IncludeList.Length > 0)
        //{
        //    foreach (var item in search.IncludeList)
        //    {
        //        entity = entity.Include(item);
        //    }
        //}

        var list = entity.ToList();
        return _mapper.Map<List<Model.Proizvodi>>(list);
    }
}