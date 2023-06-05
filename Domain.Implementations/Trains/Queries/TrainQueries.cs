namespace Domain.Implementations.Trains.Queries
{
    public class TrainQueries : ITrainQueries
    {
        private readonly IGetTrainByIdQueryContext getTrainByIdContext;
        private readonly IGetAllTrainsQueryContext getAllTrainsQueryContext;
        public TrainQueries(IGetTrainByIdQueryContext getTrainByIdContext, IGetAllTrainsQueryContext getAllTrainsQueryContext)
        {
            this.getTrainByIdContext = getTrainByIdContext;
            this.getAllTrainsQueryContext = getAllTrainsQueryContext;
        }

        public async Task<TrainDto> GetTrainAsync(GetTrainByIdQuery query)
        {
            return await getTrainByIdContext.Execute(query);
        }

        public async Task<IEnumerable<TrainDto>> GetAllTrainsAsync(GetAllTrainsQuery query)
        {
            return await getAllTrainsQueryContext.Execute(query);
        }
    }
}
