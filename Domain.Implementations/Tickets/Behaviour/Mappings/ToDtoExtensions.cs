namespace Domain.Implementations.Tickets.Behaviour.Mappings
{
    internal static class ToDtoExtensions
    {
        public static TicketDto ToDto(this TicketModel model) => new()
        {
            Id = model.Id,
            TrainId = model.TrainId,
            UserId = model.UserId,
            RailroadCar = model.RailroadCar,
            TrainSeat = model.TrainSeat,
            Price = model.Price
        };

        public static IEnumerable<TicketDto> ToDto(this IReadOnlyCollection<TicketModel> models) =>
            models.Select(m => m.ToDto()); 
    }
}
