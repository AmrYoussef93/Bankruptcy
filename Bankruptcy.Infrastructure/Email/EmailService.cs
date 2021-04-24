using Bankruptcy.Application.Common.Interfaces;
using System.Threading.Tasks;

namespace Bankruptcy.Infrastructure.Email
{
    public class EmailService : IEmailService
    {
        public Task SendRegistrationEmailAsyn(string name, string email, string confirmationCode)
        {
            throw new System.NotImplementedException();
        }
    }
}
