namespace Domain.Implementations.Users.Queries.GetByEmail
{
	public class GetUserByEmailQueryContext : IGetUserByEmailQueryContext
	{
		private readonly IUserReadRepository userReadRepository;
		private readonly IValidator<GetUserByEmailQuery> validator;

		public GetUserByEmailQueryContext(IUserReadRepository userReadRepository, IValidator<GetUserByEmailQuery> validator)
		{
			this.userReadRepository = userReadRepository;
			this.validator = validator;
		}

		public async Task<UserDto> Execute(GetUserByEmailQuery query)
		{
			var validationResult = await validator.ValidateAsync(query);

			if (!validationResult.IsValid)
			{
				var failures = validationResult.Errors.Where(v => v != null).ToList();
				throw new InvalidRequestException(new ValidationException("Validation exception", failures));
			}

			var result = await userReadRepository.GetUserAsync(new GetUserByEmailContract (query.Email));

			if (result == null) 
			{
				throw new NotFoundException("The User email was not found in the database.");
			}

			return result.ToModel().ToDto();
		}
	}
}
