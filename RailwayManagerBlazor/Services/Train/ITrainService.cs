namespace RailwayManagerBlazor.Services.Train
{
    public interface ITrainService
    {
        Task<IEnumerable<TrainModel>> GetTrains();
    }
}
