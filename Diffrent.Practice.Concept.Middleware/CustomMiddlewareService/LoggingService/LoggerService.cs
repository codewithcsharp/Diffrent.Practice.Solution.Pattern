using Diffrent.Practice.Concept.Middleware.CustomMiddlewareService.Interfaces;

namespace Diffrent.Practice.Concept.Middleware.CustomMiddlewareService.LoggingService
{
    public class LoggerService : IUseMiddleware
    {
        public async Task InvokeAsync(Func<Task> nextfunc)
        {
            await nextfunc();
        }

        public void Logger(string message)
        {
            Console.WriteLine($"Logger Service: {message}");
        }
    }
}
