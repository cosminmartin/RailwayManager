namespace Domain.Contracts.Tickets.Queries.GetById
{
    public interface IGetTicketByIdQueryContext
    {
        Task<TicketDto> Execute(GetTicketByIdQuery query);
    }
}
