namespace Domain.Contracts.Users.Queries.GetByEmail
{
	public class GetUserByEmailQuery
	{
		public string Email { get; set; }

		public GetUserByEmailQuery(string email)
		{
			Email = email;
		}
	}
}
