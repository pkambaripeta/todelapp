using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(todelapp.Startup))]
namespace todelapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
