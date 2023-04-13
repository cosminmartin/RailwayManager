namespace Libraries.Shared.Constants
{
    public static class RegexConstants
    {
        public static readonly string PasswordRequirements = @"^(?=.{5,}$)(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*\W).*$";
    }
}