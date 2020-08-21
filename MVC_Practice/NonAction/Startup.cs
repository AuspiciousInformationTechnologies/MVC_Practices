using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NonAction.Startup))]
namespace NonAction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
