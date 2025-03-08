namespace Diffrent.Practice.Concept.Middleware
{
    public class BuildProcessingRequest
    {
        public delegate Task MiddlewareDelegate(Func<Task> nextfunc);
        public static async Task LoggingMiddleware(Func<Task> nextfunc)
        {
            Console.WriteLine($"Start Logging");
            await nextfunc();
        }

        public static MiddlewareDelegate BuildMiddlewarePipeLine(List<MiddlewareDelegate> middlewareDelegates) 
        {
            MiddlewareDelegate pipeline = (next) => Task.CompletedTask;
             for( int i = middlewareDelegates.Count - 1; i >= 0; i-- )
            {
                var currentmiddleware = middlewareDelegates[i];
                var nextpipeline = pipeline;
                pipeline = (next) => currentmiddleware(() => nextpipeline(next));
            }
             return pipeline;
        }
    }
}
