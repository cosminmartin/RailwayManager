namespace Domain.Contracts.Tickets.Queries.GetById
{
    public class GetTicketByIdQuery
    {
        public Guid TicketId { get; set; }

        public GetTicketByIdQuery(Guid ticketId) 
        { 
            TicketId = ticketId;
        }
    }
}
