using dotnetcorewebapi.Contracts;
using dotnetcorewebapi.Models;

namespace dotnetcorewebapi.Repositories
{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository() : base() { }

        public IEnumerable<Hero> getByAge(int age)
        {
            return _table.Where(x => x.Age == age);
        }
    }
}
