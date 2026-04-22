namespace Mocking.BusinessLogic;

public interface IEmailSender
{
  bool SendEmail(string to, string subject, string body);
}
