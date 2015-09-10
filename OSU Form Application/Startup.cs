using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSU_Form_Application.Startup))]
namespace OSU_Form_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
