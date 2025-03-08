using Diffrent.Practice.Solution.Pattern.DesignPatterns.FactoryDesignPattern.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.FactoryDesignPattern
{
    public class SMSNotificationFactory : NotificationFactory
    {
        public override INotification NotificationMessage()
        {
            return new SMSNotification();
        }
    }
}
