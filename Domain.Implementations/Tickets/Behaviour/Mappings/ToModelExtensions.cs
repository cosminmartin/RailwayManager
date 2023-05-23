namespace Domain.Implementations.Tickets.Behaviour.Mappings
{
    internal static class ToModelExtensions
    {
        public static TicketModel ToModel(this Ticket entity) => new()
        {
            Id = entity.Id,
            TrainId = entity.TrainId,
            UserId = entity.UserId,
            RailroadCar = entity.RailroadCar,
            TrainSeat = entity.TrainSeat,
            Price = entity.Price
        };

        public static IEnumerable<TicketModel> ToModel(this IReadOnlyCollection<Ticket> entities) =>
            entities.Select(e => e.ToModel());
    }
}
