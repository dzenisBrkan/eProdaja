using eProdaja.eProdaja.Services;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.Controllers;

public class ProizvodiController : BaseCRUDController<Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
{
    public ProizvodiController(IProizvodService proizvodiService) : base(proizvodiService)
    {}
}