namespace Domain.Implementations.Users.Commands.CreateUser
{
    public class CreateUserCommandContext : ICreateUserCommandContext
    {
        private readonly IUserWriteRepository userWriteRepository;
        private readonly IValidator<CreateUserCommand> validator;
        private readonly IPasswordManager passwordValidator;
        public CreateUserCommandContext(IUserWriteRepository userWriteRepository, IValidator<CreateUserCommand> validator, IPasswordManager passwordValidator)
        {
            this.userWriteRepository = userWriteRepository;
            this.validator = validator;
            this.passwordValidator = passwordValidator;
        }

        public async Task<UserDto> Execute(CreateUserCommand command)
        {
            var validationResult = await validator.ValidateAsync(command);

            if(!validationResult.IsValid) 
            { 
                var failures = validationResult.Errors.Where(x=> x != null).ToList();

                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var passwordResponse = passwordValidator.Generate(command.Password);

            if(!passwordResponse.IsValid) 
            {
                throw new BadRequestException();
            }

            var result = await userWriteRepository.CreateUserAsync(new CreateUserContract(command.Email, command.FirstName, command.LastName, passwordResponse.Hash, passwordResponse.Salt, command.PhoneNumber));

            return result.ToModel().ToDto();
        }
    }
}
