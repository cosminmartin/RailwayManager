namespace Domain.Implementations.Trains.Queries.GetAllTrains
{
    public class GetAllTrainsQueryContext : IGetAllTrainsQueryContext
    {
        private readonly ITrainReadRepository trainReadRepository;
        private readonly IValidator<GetAllTrainsQuery> validator;

        public GetAllTrainsQueryContext(ITrainReadRepository trainReadRepository, IValidator<GetAllTrainsQuery> validator)
        {
            this.trainReadRepository = trainReadRepository;
            this.validator = validator;
        }

        public async Task<IEnumerable<TrainDto>> Execute(GetAllTrainsQuery query) 
        {
            var validationResult = await validator.ValidateAsync(query);

            if (!validationResult.IsValid)
            {
                var failures = validationResult.Errors.Where(x => x != null).ToList();

                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var result = await trainReadRepository.GetAllTrainsAsync(new GetAllTrainsContract(query.DepartureStation, query.ArrivalStation));

            if (result == null)
            {
                throw new NotFoundException("The train is not inside the database");
            }

            var trainDtos = result.Select(c => c.ToModel().ToDto());

            return trainDtos;
        }
    }
}
