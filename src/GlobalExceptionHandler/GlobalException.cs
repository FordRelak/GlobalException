namespace GlobalExceptionHandler
{
    public abstract class GlobalException : Exception
    {
        public abstract int StatusCode { get; }

        protected GlobalException() : base("Internal server error")
        {
        }

        protected GlobalException(string message) : base(message)
        {
        }
    }
}