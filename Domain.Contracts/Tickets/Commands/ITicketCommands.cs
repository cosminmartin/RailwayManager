namespace Domain.Contracts.Tickets.Commands
{
    public interface ITicketCommands
    {
        Task<TicketDto> CreateTicketAsync(CreateTicketCommand command);
    }
}
