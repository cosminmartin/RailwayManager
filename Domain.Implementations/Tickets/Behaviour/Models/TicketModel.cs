namespace Domain.Implementations.Tickets.Behaviour.Models
{
    public class TicketModel
    {
        public Guid Id { get; set; }
        public Guid TrainId { get; set; }
        public Guid UserId { get; set; }
        public int RailroadCar { get; set; }
        public int TrainSeat { get; set; }
        public decimal Price { get; set; }
    }
}
