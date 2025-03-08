namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.FactoryDesignPattern.Interfaces
{
    public abstract class NotificationFactory
    {
        public abstract INotification NotificationMessage();

        public void Notify(string message)
        {
            INotification notification = NotificationMessage();
            notification.NotifyUser(message);
        }
    }
}
