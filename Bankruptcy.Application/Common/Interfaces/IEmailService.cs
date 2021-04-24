using System.Threading.Tasks;

namespace Bankruptcy.Application.Common.Interfaces
{
    public interface IEmailService
    {
        Task SendRegistrationEmailAsyn(string name, string email, string confirmationCode);
    }
}
