namespace Domain.Contracts.Users.Commands.CreateUser
{
    public class CreateUserCommand
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public CreateUserCommand(string email, string firstName, string lastName, string password, string phoneNumber)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
}
