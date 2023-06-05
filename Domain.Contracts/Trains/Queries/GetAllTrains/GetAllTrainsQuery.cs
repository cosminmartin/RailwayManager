namespace Domain.Contracts.Trains.Queries.GetAllTrains
{
    public class GetAllTrainsQuery
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public GetAllTrainsQuery(string departureStation, string arrivalStation)
        {
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
        }
    }
}
