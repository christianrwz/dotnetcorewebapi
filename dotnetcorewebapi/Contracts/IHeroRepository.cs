using dotnetcorewebapi.Models;

namespace dotnetcorewebapi.Contracts
{
    public interface IHeroRepository : IBaseRepository<Hero>
    {
        IEnumerable<Hero> getByAge(int age);
    }
}
