using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Dla_Github.Startup))]
namespace Test_Dla_Github
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
