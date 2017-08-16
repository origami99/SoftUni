using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumbersFrom1to50.Startup))]
namespace NumbersFrom1to50
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
