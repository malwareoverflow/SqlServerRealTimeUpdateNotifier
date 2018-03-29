using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIGNALRDB.Startup))]
namespace SIGNALRDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
