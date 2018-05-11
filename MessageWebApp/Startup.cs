using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageWebApp.Startup))]
namespace MessageWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
