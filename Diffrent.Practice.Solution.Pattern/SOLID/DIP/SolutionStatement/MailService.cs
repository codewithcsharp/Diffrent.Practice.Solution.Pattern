using Diffrent.Practice.Solution.Pattern.SOLID.DIP.SolutionStatement.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.SOLID.DIP.SolutionStatement
{
    public class MailService
    {
        private readonly INotificationService _notificationService;

        public MailService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void RegisterService(string username)
        {
            _notificationService.SendNotification($"Welcome {username}");
        }
    }
}
