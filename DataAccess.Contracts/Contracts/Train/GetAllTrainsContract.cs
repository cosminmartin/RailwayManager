namespace DataAccess.Contracts.Contracts.Train
{
    public class GetAllTrainsContract
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public GetAllTrainsContract(string departureStation, string arrivalStation)
        {
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;        
        }
    }
}
