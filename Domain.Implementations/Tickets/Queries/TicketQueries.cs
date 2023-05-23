namespace Domain.Implementations.Tickets.Queries
{
    public class TicketQueries : ITicketQueries
    {
        private readonly IGetTicketByIdQueryContext getTicketByIdQueryContext;
        public TicketQueries(IGetTicketByIdQueryContext getTicketByIdQueryContext)
        {
            this.getTicketByIdQueryContext = getTicketByIdQueryContext;
        }

        public async Task<TicketDto> GetTicketAsync(GetTicketByIdQuery query)
        {
            return await getTicketByIdQueryContext.Execute(query);
        }

    }
}
