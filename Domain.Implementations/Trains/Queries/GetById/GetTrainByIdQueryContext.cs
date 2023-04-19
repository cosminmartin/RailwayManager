namespace Domain.Implementations.Trains.Queries.GetById
{
    public class GetTrainByIdQueryContext : IGetTrainByIdQueryContext
    {
        private readonly ITrainReadRepository trainReadRepository;
        private readonly IValidator<GetTrainByIdQuery> validator;
        public GetTrainByIdQueryContext(ITrainReadRepository trainReadRepository, IValidator<GetTrainByIdQuery> validator)
        {
            this.trainReadRepository = trainReadRepository;
            this.validator = validator;
        }

        public async Task<TrainDto> Execute(GetTrainByIdQuery query)
        {
            var validationResult = await validator.ValidateAsync(query);

            if(!validationResult.IsValid)
            {
                var failures = validationResult.Errors.Where(x => x != null).ToList();

                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var result = await trainReadRepository.GetTrainAsync(new GetTrainByIdContract(query.TrainId));

            if(result == null)
            {
                throw new NotFoundException("The train id is not inside the database");
            }

            return result.ToModel().ToDto();
        }
    }
}
