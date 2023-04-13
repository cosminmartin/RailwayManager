namespace Libraries.PasswordManager.Models
{
    public class PasswordResponse
    {
        public string Salt { get; set; }
        public string Hash { get; set; }
        public bool IsValid { get; set; }
        public PasswordResponse(string salt, string hash, bool isValid)
        {
            Salt = salt;
            Hash = hash;
            IsValid = isValid;
        }
    }
}
