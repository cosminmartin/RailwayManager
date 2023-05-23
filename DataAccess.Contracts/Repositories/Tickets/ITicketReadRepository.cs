namespace DataAccess.Contracts.Repositories.Tickets
{
    public interface ITicketReadRepository
    {
        Task<Ticket> GetTicketAsync(GetTicketByIdContract contract);
    }
}
