using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.eProdaja.Services;

public interface IKorisnikService
{
    List<Korisnici> Get();
    Korisnici GetById(int id);
    Korisnici Insert(KorisniciInsertRequest request);
}
