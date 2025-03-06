using Diffrent.Practice.Concept.Middleware.RequestData;

namespace Diffrent.Practice.Concept.Middleware
{
    public class ProcessingRequest
    {
        public delegate Task MiddlewareDelegate(Context context, Func<Task> nextfunc);
        public static async Task LoggingMiddleware(Context context, Func<Task> nextfunc)
        {
            Console.WriteLine($"Start Logging");
            await nextfunc();
            Console.WriteLine($"End Logging");
        }

        public static async Task AuthenticationMiddleware(Context context, Func<Task> nextfunc)
        {
            Console.WriteLine("Authentication: Checking User");
            await nextfunc();
        }

        public static MiddlewareDelegate BuildMiddlewarePipeLine(List<MiddlewareDelegate> middlewareDelegates) 
        {
            MiddlewareDelegate pipeline = (context, next) => Task.CompletedTask;
             for( int i = middlewareDelegates.Count - 1; i >= 0; i-- )
            {
                var currentmiddleware = middlewareDelegates[i];
                var nextpipeline = pipeline;
                pipeline = (context, next) => currentmiddleware(context, () => nextpipeline(context, next));
            }
             return pipeline;
        }
    }
}
