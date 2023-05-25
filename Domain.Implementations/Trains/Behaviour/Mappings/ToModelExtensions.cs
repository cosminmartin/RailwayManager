namespace Domain.Implementations.Trains.Behaviour.Mappings
{
    internal static class ToModelExtensions
    {
        public static TrainModel ToModel(this Train entity) => new()
        {
            Id = entity.Id,
            Name = entity.Name,
            DepartureStation = entity.DepartureStation,
            ArrivalStation = entity.ArrivalStation,
            DepartureDate = entity.DepartureDate,
            ArrivalDate = entity.ArrivalDate,
            Duration = entity.Duration,
            Status = entity.Status
        };

        public static IEnumerable<TrainModel> ToModel(this IEnumerable<Train> entities) =>
            entities.Select(e => e.ToModel());

        public static IEnumerable<TrainModel> ToModel(this IReadOnlyCollection<Train> entities) =>
            entities.Select(e => e.ToModel());
    }
}


