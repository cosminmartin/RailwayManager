namespace DataAccess.Contracts.Contracts.User
{
	public class GetUserByEmailContract
	{
		public string Email { get; set; }
		public GetUserByEmailContract(string email) 
		{ 
			Email = email;
		}
	}
}
