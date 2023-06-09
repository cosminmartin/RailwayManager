﻿namespace DataAccess.Implementations.Users
{
    public class UserReadRepository : RepositoryBase, IUserReadRepository
    {
        public UserReadRepository(DbContext context) : base(context) { }

        public async Task<User> GetUserAsync(GetUserByIdContract contract)
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string query = $@"SELECT * FROM Users WHERE Users.Id = @UserId";

            var parameters = new { UserId = contract.UserId };

            return await connection.QueryFirstOrDefaultAsync<User>(query, parameters);
        }

        public async Task<User> GetUserAsync(GetUserByEmailContract contract)
        {
            var connection = context.CreateConnection();
			await connection.OpenAsync();

			const string query = $@"SELECT * FROM Users WHERE Users.Email = @UserEmail";

            var parameters = new { UserEmail = contract.Email };

            return await connection.QueryFirstOrDefaultAsync<User>(query, parameters);
		}
    }
}
