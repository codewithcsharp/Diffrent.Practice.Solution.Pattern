namespace Diffrent.Practice.Concept.Middleware.CustomMiddlewareService.Interfaces
{
    public interface IUseMiddleware
    {
        public void Logger(string message);
        public Task InvokeAsync(Func<Task> nextfunc);
    }
}
