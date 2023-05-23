namespace Domain.Implementations.Tickets.Commands
{
    public class TicketCommands : ITicketCommands
    {
        private readonly ICreateTicketCommandContext createTicketCommandContext;   
        public TicketCommands(ICreateTicketCommandContext createTicketCommandContext)
        {
            this.createTicketCommandContext = createTicketCommandContext;
        }

        public async Task<TicketDto> CreateTicketAsync(CreateTicketCommand command)
        {
            return await createTicketCommandContext.Execute(command);
        }
    }
}
