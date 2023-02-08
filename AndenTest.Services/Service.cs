using AndenTest.Persistence;

namespace AndenTest.Services
{
    public abstract class Service
    {
        protected readonly AndenDBContext context;
        public Service(AndenDBContext dBContext)
        {
            context = dBContext;
        }

        protected static void Log(Exception ex)
        {
            // todo Use log4net
            Console.WriteLine($"{ex.Message}\n{ex.StackTrace}");
        }
    }
}
