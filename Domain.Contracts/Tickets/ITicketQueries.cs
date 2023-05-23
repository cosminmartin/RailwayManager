namespace Domain.Contracts.Tickets
{
    public interface ITicketQueries
    {
        Task<TicketDto> GetTicketAsync(GetTicketByIdQuery query);
    }
}
