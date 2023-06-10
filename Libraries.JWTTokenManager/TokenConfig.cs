namespace Libraries.JWTTokenManager
{
	public class TokenConfig
	{
		public int ExpireTimeInMinutes { get; set; }
		public string Audience { get; set; }
		public string Issuer { get; set; }
		public string SecretKey { get; set; }
	}
}
