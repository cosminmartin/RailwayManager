namespace Libraries.JWTTokenManager.Contracts
{
	public class TokenGenerateContract
	{
		public Dictionary<string, string> Claims { get; }
		public int ExpireTimeInMinutes { get; }
		public string SecretKey { get; }
		public string Issuer { get; }
		public string Audience { get; }

		public TokenGenerateContract(Dictionary<string, string> claims,
			int expireTime,
			string secretKey,
			string issuer,
			string audience)
		{
			Claims = claims;
			ExpireTimeInMinutes = expireTime;
			SecretKey = secretKey;
			Issuer = issuer;
			Audience = audience;
		}
	}
}
