namespace RailwayManagerBlazor.Services.Train
{
    public class TrainService : ITrainService
    {
        private readonly HttpClient httpClient;

        public TrainService(HttpClient httpClient) 
        { 
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<TrainModel>> GetTrains()
        {
            return await httpClient.GetFromJsonAsync<TrainModel[]>("api/trains");
        }
    }
}
