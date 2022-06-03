using EmailApp.Net.Models;

namespace EmailApp.Net.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
