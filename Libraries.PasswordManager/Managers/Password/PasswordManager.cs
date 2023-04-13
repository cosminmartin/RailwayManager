namespace Libraries.PasswordManager.Managers.Password
{
    public class PasswordManager : IPasswordManager 
    {
        public ISaltManager SaltManager { get; private set; }
        private PasswordValidator? PasswordValidator { get; set; }
        public PasswordManager(ISaltManager saltManager, PasswordValidator? passwordValidator = null)
        {
            SaltManager = saltManager;
            PasswordValidator = passwordValidator;
        }

        public PasswordResponse Generate(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return new PasswordResponse(string.Empty, string.Empty, false);
            if (PasswordValidator != null && !PasswordValidator.ValidatePassword(password))
                return new PasswordResponse(string.Empty, string.Empty, false);

            var salt = SaltManager.SaltGenerator();
            var saltBytes = Convert.FromHexString(salt);

            var hashBytes = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                saltBytes,
                LibraryConstants.Iterations,
                LibraryConstants.HashAlgorithm,
                LibraryConstants.KeySize);

            var hash = Convert.ToHexString(hashBytes);

            return new PasswordResponse(salt, hash, true);
        }

        public bool Verify(string password, string hash, string salt)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            var saltBytes = Convert.FromHexString(salt);

            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                saltBytes,
                LibraryConstants.Iterations,
                LibraryConstants.HashAlgorithm,
                LibraryConstants.KeySize);

            var hashToCompareString = Convert.ToHexString(hashToCompare);

            return hashToCompareString == hash;
        }
    }
}
