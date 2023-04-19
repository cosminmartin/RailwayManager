namespace DataAccess.Contracts.Entities
{
    public class TrainUser
    {
        public Guid Id { get; set; }
        public Guid TrainId { get; set; }
        public Guid UserId { get; set; }
    }
}
