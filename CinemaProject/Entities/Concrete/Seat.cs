using CinemaProject.Entities.Abstract;

namespace CinemaProject.Entities.Concrete
{
    public class Seat : IEntity
    {
        public short Id { get; set; }
        public bool CheckFill { get; set; }
    }
}
