using dotnetcorewebapi.Contracts;
using dotnetcorewebapi.Models;

namespace dotnetcorewebapi.Controllers
{
    public class PositionController : BaseController<Position>
    {
        public PositionController(IBaseRepository<Position> repository) : base(repository)
        {
        }
    }
}
