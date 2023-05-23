namespace DataAccess.Implementations.Tickets
{
    public class TicketWriteRepository : RepositoryBase, ITicketWriteRepository
    {
        public TicketWriteRepository(DbContext context) : base(context) { }

        public async Task<Ticket> CreateTicketAsync(CreateTicketContract contract)
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string command = $@"
                                DECLARE @TicketId table([Id] [uniqueidentifier]); 
                                INSERT INTO TICKETS (TrainId, UserId, RailroadCar, TrainSeat, Price)
                                OUTPUT INSERTED.[Id] INTO @TicketId
                                VALUES (@TrainId, @UserId, @RailroadCar, @TrainSeat, @Price)
                                SELECT * from Tickets where Id = (Select Id from @TicketId)";

            return await connection.QuerySingleAsync<Ticket>(command, contract);
        }
    }
}
