namespace Domain.Implementations.Trains.Queries
{
    public class TrainQueries : ITrainQueries
    {
        private readonly IGetTrainByIdQueryContext getTrainByIdContext;
        public TrainQueries(IGetTrainByIdQueryContext getTrainByIdContext)
        {
            this.getTrainByIdContext = getTrainByIdContext;
        }

        public async Task<TrainDto> GetTrainAsync(GetTrainByIdQuery query)
        {
            return await getTrainByIdContext.Execute(query);
        }
    }
}
