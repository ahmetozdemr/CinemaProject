using CinemaProject.Entities.Abstract;

namespace CinemaProject.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
