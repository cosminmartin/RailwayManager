namespace DataAccess.Contracts.Contracts.Ticket
{  
    public class CreateTicketContract
    {
        public Guid TrainId { get; set; }
        public Guid UserId { get; set; }
        public int RailroadCar { get; set; }
        public int TrainSeat { get; set; }
        public decimal Price { get; set; }

        public CreateTicketContract(Guid trainId, Guid userId, int railroadCar, int trainSeat, decimal price)
        {
            TrainId = trainId;
            UserId = userId;
            RailroadCar = railroadCar;
            TrainSeat = trainSeat;
            Price = price;
        }
    }
}
