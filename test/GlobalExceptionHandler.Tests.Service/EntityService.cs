namespace GlobalExceptionHandler.Tests.Service
{
    public class EntityService
    {
        public static IEnumerable<Entity> GetCollection()
        {
            return new Entity[]
            {
                new(),
                new(),
                new(),
                new(),
            };
        }

        public static Entity GetNotFoundException()
        {
            throw new NotFoundException();
        }

        public static Entity GetBadRequestException()
        {
            throw new BadRequestException();
        }
    }
}