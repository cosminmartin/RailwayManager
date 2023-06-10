using Libraries.JWTTokenManager.Contracts;
using Libraries.JWTTokenManager;

namespace Domain.Implementations.Users.Commands.LoginUser
{
	public class LoginUserCommandContext : ILoginUserCommandContext
	{
		private readonly IUserReadRepository userReadRepository;
		private readonly IPasswordManager passwordManager;
		private readonly IValidator<LoginUserCommand> validator;
		private readonly ITokenGenerator tokenGenerator;
		private readonly IOptions<TokenConfig> tokenConfig;

		public LoginUserCommandContext(IUserReadRepository userReadRepository, IPasswordManager passwordManager, IValidator<LoginUserCommand> validator, ITokenGenerator tokenGenerator, IOptions<TokenConfig> tokenConfig)
		{
			this.userReadRepository = userReadRepository;
			this.passwordManager = passwordManager;
			this.validator = validator;
			this.tokenGenerator = tokenGenerator;
			this.tokenConfig = tokenConfig;
		}

		public async Task<UserTokenDto> Execute(LoginUserCommand command)
		{
			var validationResult = await validator.ValidateAsync(command);

			if (!validationResult.IsValid)
			{
				var failures = validationResult.Errors.Where(x => x != null).ToList();

				throw new InvalidRequestException(new ValidationException("Validation exception", failures));
			}

			var user = (await userReadRepository.GetUserAsync(new GetUserByEmailContract(command.Email)))?.ToModel();

			if (user == null)
			{
				throw new BadRequestException();
			}

			if (!passwordManager.Verify(command.Password, user.PasswordHash, user.PasswordSalt))
			{
				throw new BadRequestException();
			}

			var claims = new Dictionary<string, string>
			{
				{ "Email", user.Email},
				{ "FirstName", user.FirstName },
				{ "LastName", user.LastName},
				{ "PhoneNumber", user.PhoneNumber }
			};

			var contract = new TokenGenerateContract(claims,
				tokenConfig.Value.ExpireTimeInMinutes, tokenConfig.Value.SecretKey,
				tokenConfig.Value.Issuer, tokenConfig.Value.Audience);
			var token = tokenGenerator.GenerateToken(contract);

			if (string.IsNullOrEmpty(token))
			{
				throw new BadRequestException();
			}
			return user.ToDto(token);
		}
	}
}
