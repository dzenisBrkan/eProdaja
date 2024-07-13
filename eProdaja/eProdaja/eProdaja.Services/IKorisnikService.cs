using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.eProdaja.Services;

public interface IKorisnikService
{
    List<Korisnici> Get(KorisniciSearchRequest request);
    Korisnici GetById(int id);
    Korisnici Insert(KorisniciInsertRequest request);
    Korisnici Update(int id, KorisniciInsertRequest request);
}
