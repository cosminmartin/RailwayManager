namespace Libraries.JWTTokenManager
{
	public class TokenGenerator : ITokenGenerator
	{
		public string GenerateToken(TokenGenerateContract contract)
		{
			if (!contract.Claims.Any() && contract.ExpireTimeInMinutes <= 0 && string.IsNullOrEmpty(contract.SecretKey))
			{
				return string.Empty;
			}

			var claims = contract.Claims.Select(kvp => new Claim(kvp.Key, kvp.Value)).ToList();

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(contract.SecretKey));
			var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(claims),
				Expires = DateTime.UtcNow.AddMinutes(contract.ExpireTimeInMinutes),
				Issuer = contract.Issuer,
				Audience = contract.Audience,
				SigningCredentials = credentials
			};

			var tokenHandler = new JwtSecurityTokenHandler();
			var token = tokenHandler.CreateToken(tokenDescriptor);
			return tokenHandler.WriteToken(token);
		}
	}
}
