namespace DataAccess.Contracts.Repositories.Trains
{
    public interface ITrainWriteRepository
    {
        Task<Train> CreateTrainAsync(CreateTrainContract contract);
        Task<Train> EditTrainAsync(EditTrainContract contract);
        Task<int> DeleteTrainAsync(DeleteTrainContract contract);
    }
}
