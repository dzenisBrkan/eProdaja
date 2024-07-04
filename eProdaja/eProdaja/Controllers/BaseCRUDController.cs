using eProdaja.eProdaja.Services;
using eProdaja.Model;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers;

public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseReadController<T, TSearch> where T : class where TSearch : class where TInsert : class where TUpdate : class
{
    protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudServices;
    public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
    {
        _crudServices = service;
    }

    [HttpPost]
    public T Insert([FromBody] TInsert request)
    {
        return _crudServices.Insert(request);
    }

    [HttpPut("{id}")]
    public T Update(int id, [FromBody] TUpdate request)
    {
        return _crudServices.Update(id,request);
    }
}
