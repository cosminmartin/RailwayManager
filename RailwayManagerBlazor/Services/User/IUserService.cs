namespace RailwayManagerBlazor.Services.User
{
	public interface IUserService 
	{
		Task<UserModel> GetUser(Guid UserId);
	}
}
