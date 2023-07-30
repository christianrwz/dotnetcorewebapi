using dotnetcorewebapi.Contracts;

namespace dotnetcorewebapi.Models
{
    public class Position : IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
