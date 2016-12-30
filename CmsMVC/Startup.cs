using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CmsMVC.Startup))]
namespace CmsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
