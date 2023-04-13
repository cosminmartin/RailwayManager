namespace Libraries.PasswordManager.Validators
{
    public class PasswordValidator
    {
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            public bool ValidatePassword(string password)
            {
                return validateGuidRegex.IsMatch(password);
            }     
    }
}
