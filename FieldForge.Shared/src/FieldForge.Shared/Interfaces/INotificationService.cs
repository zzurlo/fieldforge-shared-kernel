using System.Threading.Tasks;

namespace FieldForge.Shared.Interfaces
{
    /// <summary>
    /// Interface for sending notifications via email and SMS
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Sends an email asynchronously
        /// </summary>
        /// <param name="toEmail">Recipient email address</param>
        /// <param name="subject">Email subject</param>
        /// <param name="body">Email body content</param>
        /// <returns>A task representing the asynchronous operation</returns>
        Task SendEmailAsync(string toEmail, string subject, string body);

        /// <summary>
        /// Sends an SMS message asynchronously
        /// </summary>
        /// <param name="toPhone">Recipient phone number</param>
        /// <param name="messageText">SMS message content</param>
        /// <returns>A task representing the asynchronous operation</returns>
        Task SendSmsAsync(string toPhone, string messageText);
    }
}