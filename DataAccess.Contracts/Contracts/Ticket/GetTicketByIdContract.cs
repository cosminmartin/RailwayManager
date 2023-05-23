namespace DataAccess.Contracts.Contracts.Ticket
{
    public class GetTicketByIdContract
    {
        public Guid TicketId { get; set; }

        public GetTicketByIdContract(Guid ticketId)
        {
            TicketId = ticketId;
        }
    }
}
