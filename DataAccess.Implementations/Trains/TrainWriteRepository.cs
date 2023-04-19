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
    }
}
