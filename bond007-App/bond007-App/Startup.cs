using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bond007_App.Startup))]
namespace bond007_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
