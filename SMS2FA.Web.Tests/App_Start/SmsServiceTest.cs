using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Moq;
using NUnit.Framework;
using Twilio.Clients;
using Twilio.Http;

namespace SMS2FA.Web.Tests.App_Start
{
    public class SmsServiceTest
    {
        [Test]
        public async Task WhenSendAsync_MessageIsSent()
        {
            var mockClient = new Mock<ITwilioRestClient>();
            var smsService = new SmsService(mockClient.Object);
            mockClient
                .Setup(c => c.RequestAsync(It.Is<Request>(
                    r => r.Method == HttpMethod.Post &&
                    r.ConstructUrl().AbsoluteUri.Contains("Messages.json"))
                    ))
                .Returns(Task.FromResult(new Response(System.Net.HttpStatusCode.OK, "")));
            var identityMessage = new IdentityMessage
            {
                Destination = "+555 555",
                Body = "Your security code is 914203"
            };
            await smsService.SendAsync(identityMessage);

            mockClient.Verify(c => c.RequestAsync(It.Is<Request>(
                    r => Equals(r.Method, HttpMethod.Post) &&
                    r.ConstructUrl().AbsoluteUri.Contains("Messages.json")) 
                    ), Times.Once);
        }
    }
}
