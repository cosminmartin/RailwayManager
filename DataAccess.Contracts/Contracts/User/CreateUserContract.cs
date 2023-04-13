namespace DataAccess.Contracts.Contracts.User
{
    public class CreateUserContract
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string PhoneNumber { get; set; }

        public CreateUserContract(string email, string firstName, string lastName, string passwordHash, string passwordSalt, string phoneNumber)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            PhoneNumber = phoneNumber;
        }
    }
}
