namespace Domain.Contracts.Dtos.Ticket
{
    public class CreateTicketDto
    {
        public Guid TrainId { get; set; }
        public Guid UserId { get; set; }
        public int RailroadCar { get; set; }
        public int TrainSeat { get; set; }
        public decimal Price { get; set; }
    }
}
