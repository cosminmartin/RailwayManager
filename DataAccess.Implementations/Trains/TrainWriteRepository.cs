namespace DataAccess.Implementations.Trains
{
    public class TrainWriteRepository : RepositoryBase, ITrainWriteRepository
    {
        public TrainWriteRepository(DbContext context) : base(context) { }

        public async Task<Train> CreateTrainAsync(CreateTrainContract contract)
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string command = $@"
                                DECLARE @TrainId table([Id] [uniqueidentifier]); 
                                INSERT INTO TRAINS (Name, DepartureStation, ArrivalStation, DepartureDate, ArrivalDate, Duration, Status)
                                OUTPUT INSERTED.[Id] INTO @TrainId
                                VALUES (@Name, @DepartureStation, @ArrivalStation, @DepartureDate, @ArrivalDate, @Duration, @Status)
                                SELECT * from Trains where Id = (Select Id from @TrainId)";

            return await connection.QuerySingleAsync<Train>(command, contract);
        }

        public async Task<Train> EditTrainAsync(EditTrainContract contract)
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string command = @"
                                UPDATE Trains SET 
                                    Name = @Name,
                                    DepartureStation = @DepartureStation,
                                    ArrivalStation = @ArrivalStation,
                                    DepartureDate = @DepartureDate,
                                    ArrivalDate = @ArrivalDate,
                                    Duration = @Duration,
                                    Status = @Status
                                WHERE Id = @TrainId;
                                SELECT * FROM Trains WHERE Id = @TrainId;";

            return await connection.QuerySingleAsync<Train>(command, contract);
        }

        public async Task<int> DeleteTrainAsync(DeleteTrainContract contract)
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string command = "DELETE FROM Trains WHERE Id = @TrainId";

            return await connection.ExecuteAsync(command, contract);
        }
    }
}
 