namespace DataAccess.Contracts.Repositories.Trains
{
    public interface ITrainReadRepository
    {
        Task<Train> GetTrainAsync(GetTrainByIdContract contract);
    }
}
