namespace Domain.Implementations.Trains.Behaviour.Mappings
{
    internal static class ToDtoExtensions
    {
        public static TrainDto ToDto(this TrainModel model) => new()
        {
            Id = model.Id,
            Name = model.Name,
            DepartureStation = model.DepartureStation,
            ArrivalStation = model.ArrivalStation,
            DepartureDate = model.DepartureDate,
            ArrivalDate = model.ArrivalDate,
            Duration = model.Duration,
            Status = model.Status
        };

        public static IEnumerable<TrainDto> ToDto(this IReadOnlyCollection<TrainModel> models) =>
            models.Select(m => m.ToDto());
    }
}