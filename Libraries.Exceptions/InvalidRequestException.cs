namespace Libraries.Exceptions
{
    public class InvalidRequestException : Exception
    {
        public ValidationException ValidationException { get; }
        public InvalidRequestException() { }
        public InvalidRequestException(string error) : base(error) { }
        public InvalidRequestException(ValidationException validationException)
        {
            ValidationException = validationException;
        }
    }
}
