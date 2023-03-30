namespace Domain.Implementations.Users.Queries.GetById
{
    public class GetUserByIdQueryContext : IGetUserByIdQueryContext
    {
        private readonly IUserReadRepository userReadRepository;
        private readonly IValidator<GetUserByIdQuery> validator;
        public GetUserByIdQueryContext(IUserReadRepository userReadRepository, IValidator<GetUserByIdQuery> validator)
        {
            this.userReadRepository = userReadRepository;
            this.validator = validator;
        }

        public async Task<UserDto> Execute(GetUserByIdQuery query)
        {
            var validationResult = await validator.ValidateAsync(query);

            if (!validationResult.IsValid)
            {
                var failures = validationResult.Errors.Where(v => v != null).ToList();
                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var result = await userReadRepository.GetUserAsync(new GetUserByIdContract(query.UserId));

            if(result == null)
            {
                throw new NotFoundException("The User id was not found in the database.");
            }

            return result.ToModel().ToDto();
        }
    }
}
