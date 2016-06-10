using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JavaScriptWebApp.Startup))]
namespace JavaScriptWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
