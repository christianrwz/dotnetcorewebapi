using dotnetcorewebapi.Contracts;
using dotnetcorewebapi.Infrastructure;

namespace dotnetcorewebapi.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : IBaseModel
    {
        private readonly FakeDbContext _context = new();
        public readonly List<T> _table;
        public BaseRepository()
        {
            _table = _context.GetTable<T>();
        }
        public void Add(T t)
        {
            t.Id = _table.Count + 1;
            _table.Add(t);
        }

        public void Delete(int id)
        {
            _table.RemoveAll(u => u.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _table;
        }

        public T GetOne(int id)
        {
            return _table.FirstOrDefault(u => u.Id == id);
        }

        public void Update(T t)
        {
            var index = _table.FindIndex(u => u.Id == t.Id);
            _table[index] = t;
        }
    }
}
