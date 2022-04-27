namespace GlobalExceptionHandler.Tests.Service
{
    public class BadRequestException : GlobalException
    {
        public BadRequestException() : base("Bad request")
        {
        }

        public BadRequestException(string message) : base(message)
        {
        }

        public override int StatusCode => 400;
    }
}