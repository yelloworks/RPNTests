using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPNTests.Startup))]
namespace RPNTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
