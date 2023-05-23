namespace DataAccess.Implementations.Tickets
{
    public class TicketReadRepository : RepositoryBase, ITicketReadRepository
    {
        public TicketReadRepository(DbContext context) : base(context) { }

        public async Task<Ticket> GetTicketAsync(GetTicketByIdContract contract) 
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string query = $@"SELECT * FROM Tickets WHERE Tickets.Id = @TicketId";
            var parameters = new { TicketId = contract.TicketId };

            return await connection.QueryFirstOrDefaultAsync<Ticket>(query, parameters);
        }
    }
}
