namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.SingletonDesignPattern
{
    public class SingletonInstance
    {
        private static SingletonInstance? _instance;
        private static readonly object _lock = new();

        private SingletonInstance() { }

        public static SingletonInstance Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new SingletonInstance();
                }
                return _instance;
            }
        }
    }
}
