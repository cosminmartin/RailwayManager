namespace Libraries.PasswordManager.Factory
{
    public class PasswordManagerFactory
    {
        public static IPasswordManager CreateDefaultManager()
        {
            return new Managers.Password.PasswordManager(new SaltManager());
        }

        public static IPasswordManager CreateManagerWithValidation()
        {
            return new Managers.Password.PasswordManager(new SaltManager(), new Validators.PasswordValidator());
        }
    }
}
