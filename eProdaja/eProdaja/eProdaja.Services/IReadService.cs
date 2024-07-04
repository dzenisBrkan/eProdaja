namespace eProdaja.eProdaja.Services;

public interface IReadService<T, TSearch> where T : class where TSearch : class
{
    IEnumerable<T> Get(TSearch search = null);
    public T GetById(int id);
}
