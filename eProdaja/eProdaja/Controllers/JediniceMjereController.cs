using eProdaja.eProdaja.Services;
using eProdaja.Model;

namespace eProdaja.Controllers;

public class JediniceMjereController : BaseReadController<JediniceMjere, object>
{
    public JediniceMjereController(IJedinicaMjereServices jediniceMjereService):base(jediniceMjereService)
    {}
}
