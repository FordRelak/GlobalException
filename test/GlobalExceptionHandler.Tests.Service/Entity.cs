using System.Security.Cryptography;

namespace GlobalExceptionHandler.Tests.Service
{
    public class Entity
    {
        public int Id { get; set; } = RandomNumberGenerator.GetInt32(1000);
        public string Text { get; set; } = "Text " + RandomNumberGenerator.GetInt32(1000);
    }
}