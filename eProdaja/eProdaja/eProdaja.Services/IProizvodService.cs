using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.eProdaja.Services;

public interface IProizvodService : ICRUDService<Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
{}