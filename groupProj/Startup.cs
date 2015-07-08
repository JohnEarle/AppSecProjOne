using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(groupProj.Startup))]
namespace groupProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
