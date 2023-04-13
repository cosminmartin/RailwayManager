using DataAccess.Contracts.Contracts.User;

namespace DataAccess.Contracts.Repositories.Users
{
    public interface IUserWriteRepository
    {
        Task<User> CreateUserAsync(CreateUserContract contract);
    }
}
