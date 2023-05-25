namespace Domain.Contracts.Trains.Commands.EditTrain
{
    public class EditTrainCommand
    {
        public Guid TrainId { get; set; }
        public string Name { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime Duration { get; set; }
        public string Status { get; set; }

        public EditTrainCommand(Guid trainId, string name, string departureStation, string arrivalStation, DateTime departureDate, DateTime arrivalDate, DateTime duration, string status)
        {
            TrainId = trainId;
            Name = name;
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            Duration = duration;
            Status = status;
        }
    }
}
