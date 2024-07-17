using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using eProdaja.Model.Requests;
using System.Security.Cryptography;
using System.Text;

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

    public List<Model.Korisnici> Get(KorisniciSearchRequest request)
    {
        var query = _context.Korisnicis.AsQueryable();

        if (!string.IsNullOrWhiteSpace(request?.Ime))
        {
            query = query.Where(x=>x.Ime.StartsWith(request.Ime));
        }
        if (!string.IsNullOrWhiteSpace(request?.Prezime))
        {
            query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
        }

        var list = query.ToList();
        return _mapper.Map<List<Model.Korisnici>>(list);
    }

    public Model.Korisnici GetById(int id)
    {
        var entity = _context.Korisnicis.Find(id);

        return _mapper.Map<Model.Korisnici>(entity);
    }

    public Model.Korisnici Insert(KorisniciInsertRequest request)
    {
        var entity = _mapper.Map<Database.Korisnici>(request);
        _context.Korisnicis.Add(entity);

        if (request.Password != request.PasswordPotvrda)
        {
            throw new Exception("Unesite isti password");
        }

        entity.LozinkaSalt = GenerateSalt();
        entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

        _context.SaveChanges();

        foreach (var uloga in request.Uloge)
        {
            Database.KorisniciUloge korisniciUloge = new KorisniciUloge();
            korisniciUloge.KorisnikId = entity.KorisnikId;
            korisniciUloge.UlogaId = uloga;
            korisniciUloge.DatumIzmjene = DateTime.Now;

            _context.KorisniciUloges.Add(korisniciUloge);
        }

        _context.SaveChanges();
        return _mapper.Map<Model.Korisnici>(entity);
    }

    public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
    {
        var entity = _context.Korisnicis.Find(id);

        _mapper.Map(request, entity);

        //if (!string.IsNullOrWhiteSpace(request.Password))
        //{
        //    if(request.Password != request.PasswordPotvrda)
        //    {
        //        throw new Exception("Passwordi se ne slazu!");
        //    }
        //    //TODO: update password
        //}
        _context.SaveChanges();
        return _mapper.Map<Model.Korisnici>(entity);
    }

    public static string GenerateSalt()
    {
        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        var byteArray = new byte[16];
        provider.GetBytes(byteArray);


        return Convert.ToBase64String(byteArray);
    }
    public static string GenerateHash(string salt, string password)
    {
        byte[] src = Convert.FromBase64String(salt);
        byte[] bytes = Encoding.Unicode.GetBytes(password);
        byte[] dst = new byte[src.Length + bytes.Length];

        System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
        System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

        HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
        byte[] inArray = algorithm.ComputeHash(dst);
        return Convert.ToBase64String(inArray);
    }
}