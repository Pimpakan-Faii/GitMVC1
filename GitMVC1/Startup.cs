using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitMVC1.Startup))]
namespace GitMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
