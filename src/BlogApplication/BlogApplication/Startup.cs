using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogApplication.Startup))]
namespace BlogApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
