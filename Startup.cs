using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5032Assignment.Startup))]
namespace _5032Assignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
