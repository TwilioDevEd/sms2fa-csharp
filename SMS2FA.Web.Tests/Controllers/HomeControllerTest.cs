using NUnit.Framework;
using SMS2FA.Web.Controllers;
using TestStack.FluentMVCTesting;

namespace SMS2FA.Web.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            var controller = new HomeController();
            controller.WithCallTo(c => c.Index())
                .ShouldRenderDefaultView();
        }
    }
}
