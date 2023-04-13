using DataAccess.Contracts.Contracts.User;

namespace DataAccess.Implementations.Users
{
    public class UserWriteRepository : RepositoryBase, IUserWriteRepository
    {
        public UserWriteRepository(DbContext context) : base(context) { }
        
        public async Task<User> CreateUserAsync(CreateUserContract contract)
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string command = $@"DECLARE @UserId table([Id] [uniqueidentifier]); 
                                INSERT INTO Users (Email, FirstName, LastName, PasswordHash, PasswordSalt, PhoneNumber)
                                OUTPUT INSERTED.[Id] INTO @UserId
                                VALUES (@Email, @FirstName, @LastName, @PasswordHash, @PasswordSalt, @PhoneNumber)
								
                                SELECT * from Users where Id = (Select Id from @UserId)";

            return await connection.QuerySingleAsync<User>(command, contract);
        }
    }
}
