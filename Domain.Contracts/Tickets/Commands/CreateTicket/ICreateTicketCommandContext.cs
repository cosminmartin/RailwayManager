namespace Domain.Contracts.Tickets.Commands.CreateTicket
{
    public interface ICreateTicketCommandContext
    {
        Task<TicketDto> Execute(CreateTicketCommand command);
    }
}
