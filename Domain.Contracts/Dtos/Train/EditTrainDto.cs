﻿namespace Domain.Contracts.Dtos.Train
{
    public class EditTrainDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime Duration { get; set; }
        public string Status { get; set; }
    }
}
