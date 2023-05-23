namespace DataAccess.Contracts.Repositories.Tickets
{
    public interface ITicketWriteRepository
    {
        Task<Ticket> CreateTicketAsync(CreateTicketContract contract);
    }
}
