using eProdaja.eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers;

public class UlogeController : BaseReadController<Uloge, object>
{
    public UlogeController(IReadService<Uloge, object> service) : base(service)
    { }
}
