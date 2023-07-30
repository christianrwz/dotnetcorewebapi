namespace dotnetcorewebapi.Contracts
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetOne(int id);
        void Add(T t);
        void Update(T t);
        void Delete(int id);
    }
}
