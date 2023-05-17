using CinemaProject.Entities.Abstract;

namespace CinemaProject.Entities.Concrete
{
    public class Seat : IEntity
    {
        public int Id { get; set; }
        public bool CheckFill { get; set; }
    }
}
