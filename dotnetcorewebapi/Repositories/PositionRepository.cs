using dotnetcorewebapi.Contracts;
using dotnetcorewebapi.Models;

namespace dotnetcorewebapi.Repositories
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository() : base() { }
    }
}
