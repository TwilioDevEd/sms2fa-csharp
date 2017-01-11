using System.Threading.Tasks;
using AirTNG.Web.Domain.Reservations;
using Microsoft.AspNet.Identity;
using Moq;
using NUnit.Framework;

namespace SMS2FA.Web.Tests
{
    public class SmsServiceTest
    {
        [Test]
        public async Task WhenSendAsync_MessageIsSent()
        {
            var mockClient = new Mock<ITwilioMessageSender>();
            var smsService = new SmsService(mockClient.Object);
            var identityMessage = new IdentityMessage
            {
                Destination = "+555 555",
                Body = "Your security code is 914203"
            };

            await smsService.SendAsync(identityMessage);

            mockClient
                .Verify(c => c.SendMessageAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), 
                        Times.Once);
        }
    }
}
