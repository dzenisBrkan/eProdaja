namespace eProdaja.eProdaja.Services;

public interface IReadService<T> where T : class
{
    IEnumerable<T> Get();
    public T GetById(int id);
}
