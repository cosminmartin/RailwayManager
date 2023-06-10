namespace Libraries.JWTTokenManager
{
	public interface ITokenGenerator
	{
		public string GenerateToken(TokenGenerateContract contract);
	}
}
