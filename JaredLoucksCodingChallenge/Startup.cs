using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JaredLoucksCodingChallenge.Startup))]
namespace JaredLoucksCodingChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
