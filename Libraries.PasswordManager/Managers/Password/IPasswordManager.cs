namespace Libraries.PasswordManager.Managers.Password
{
    public interface IPasswordManager
    {
        PasswordResponse Generate(string password);
        bool Verify(string password, string hash, string salt);   
    }
}
