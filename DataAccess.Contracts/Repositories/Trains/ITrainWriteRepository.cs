namespace DataAccess.Contracts.Repositories.Trains
{
    public interface ITrainWriteRepository
    {
        Task<Train> CreateTrainAsync(CreateTrainContract contract);
    }
}
