namespace eProdaja.eProdaja.Services;

public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IReadService<T, TSearch> where TInsert : class where TUpdate : class where T : class where TSearch : class
{
    T Insert(TInsert request);
    T Update(int id, TUpdate request);
}
