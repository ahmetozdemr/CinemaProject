namespace CinemaProject.Entity
{
    public class Seat: IEntity
    {
        public short Id { get; set; }
        public bool CheckFill { get; set; }
    }
}
