using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloApsMvc.Startup))]
namespace HelloApsMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
