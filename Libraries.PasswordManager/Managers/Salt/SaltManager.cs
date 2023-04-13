namespace Libraries.PasswordManager.Managers.Salt
{
    public class SaltManager : ISaltManager
    {
        public string SaltGenerator()
        {
            byte[] saltBytes = new byte[LibraryConstants.KeySize];
            RandomNumberGenerator.Fill(saltBytes);
            var salt = Convert.ToHexString(saltBytes);
            return salt;
        }
    }
}
