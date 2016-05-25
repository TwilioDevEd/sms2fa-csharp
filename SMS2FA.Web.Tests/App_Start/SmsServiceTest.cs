using Microsoft.AspNet.Identity;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using Twilio;
using WarmTransfer.Web.Domain;

namespace SMS2FA.Web.Tests.App_Start
{
    public class SmsServiceTest
    {
        [Test]
        public async Task WhenSendAsync_MessageIsSent()
        {
            var mockClient = new Mock<TwilioRestClient>(string.Empty, string.Empty);
            var smsService = new SmsService(mockClient.Object);

            var identityMessage = new IdentityMessage
            {
                Destination = "+555 555",
                Body = "Your security code is 914203"
            };
            await smsService.SendAsync(identityMessage);

            mockClient.Verify(
                c => c.SendMessage(Config.TwilioNumber, identityMessage.Destination, identityMessage.Body), Times.Once);
        }
    }
}
