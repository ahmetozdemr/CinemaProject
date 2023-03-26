using CinemaProject.Entities.Abstract;

namespace CinemaProject.Entities.Concrete
{
    public class Film : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
    }
}
