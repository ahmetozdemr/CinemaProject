namespace CinemaProject.Entity
{
    public class Film: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public float Price { get; set; }
    }
}
