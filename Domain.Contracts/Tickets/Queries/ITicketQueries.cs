namespace Domain.Contracts.Tickets.Queries
{
    public interface ITicketQueries
    {
        Task<TicketDto> GetTicketAsync(GetTicketByIdQuery query);
    }
}
