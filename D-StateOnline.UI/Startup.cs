using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(D_StateOnline.UI.Startup))]
namespace D_StateOnline.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
