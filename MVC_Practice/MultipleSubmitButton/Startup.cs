using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleSubmitButton.Startup))]
namespace MultipleSubmitButton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
