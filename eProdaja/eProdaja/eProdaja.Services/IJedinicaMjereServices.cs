using eProdaja.Model;

namespace eProdaja.eProdaja.Services;

public interface IJedinicaMjereServices
{
    IEnumerable<JediniceMjere> Get();
    public JediniceMjere GetById(int id);
}
