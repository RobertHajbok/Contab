using System.Threading.Tasks;
using Contab.Models.TokenAuth;
using Contab.Web.Controllers;
using Shouldly;
using Xunit;

namespace Contab.Web.Tests.Controllers
{
    public class HomeController_Tests: ContabWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}