using Diffrent.Practice.Concept.Middleware.CustomMiddlewareService.Interfaces;

namespace Diffrent.Practice.Concept.Middleware.CustomMiddlewareService
{
    public class BuildMiddlewareRequest
    {
        public delegate Task MiddlewareDelegate(Func<Task> nextfunc);
        public static async Task LoggingMiddleware(Func<Task> nextfunc)
        {
            Console.WriteLine($"Start Logging");
            await nextfunc();
        }

        public static MiddlewareDelegate BuildMiddlewarePipeline(IEnumerable<IUseMiddleware> middlewareDelegates)
        {
            MiddlewareDelegate pipeline = (next) => Task.CompletedTask;
            foreach (var middleware in middlewareDelegates)
            {
                var nextpipeline = pipeline;
                pipeline = async (next) => await middleware.InvokeAsync(() => nextpipeline(next));
            }
            return pipeline;
        }
    }
}
