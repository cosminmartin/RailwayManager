namespace RailwayManagerBlazor.Services.User
{
	public interface IUserService 
	{
		Task<LoginModel> AuthenticateUser(string email, string password);
		//Task<LoginModel> AddUser(string email, string password);
	}
}
