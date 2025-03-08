namespace Diffrent.Practice.Solution.Pattern.SOLID.DIP.ProblemStatement
{
    public class MailService
    {
        private readonly EmailService _emailService;
        public MailService()
        {
            _emailService = new EmailService();
        }

        public void RegisterService(string username)
        {
            _emailService.SendEmail($"Welcome {username}");
        }
    }
}
