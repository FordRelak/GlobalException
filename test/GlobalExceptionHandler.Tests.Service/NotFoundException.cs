namespace GlobalExceptionHandler.Tests.Service
{
    public class NotFoundException : GlobalException
    {
        public override int StatusCode => 404;

        public NotFoundException() : base("Contrete exception")
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }
    }
}