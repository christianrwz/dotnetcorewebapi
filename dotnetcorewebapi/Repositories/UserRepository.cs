using dotnetcorewebapi.Contracts;
using dotnetcorewebapi.Models;

namespace dotnetcorewebapi.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base() { }
    }
}
