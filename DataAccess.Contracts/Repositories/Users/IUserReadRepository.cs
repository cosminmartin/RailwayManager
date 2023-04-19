namespace DataAccess.Contracts.Repositories.Users
{
    public interface IUserReadRepository
    {
        Task<User> GetUserAsync(GetUserByIdContract contract);
    }
}
