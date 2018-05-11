using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingalrApplication.Startup))]
namespace SingalrApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
