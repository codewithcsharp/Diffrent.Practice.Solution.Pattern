using Diffrent.Practice.Solution.Pattern.DesignPatterns.FactoryDesignPattern.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.FactoryDesignPattern
{
    public class EmailNotificationFactory : NotificationFactory
    {
        public override INotification NotificationMessage()
        {
            return new EmailNotification();
        }
    }
}
