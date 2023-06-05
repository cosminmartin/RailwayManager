namespace DataAccess.Contracts.Repositories.Trains
{
    public interface ITrainReadRepository
    {
        Task<Train> GetTrainAsync(GetTrainByIdContract contract);
        Task<IEnumerable<Train>> GetAllTrainsAsync(GetAllTrainsContract contract);
    }
}
