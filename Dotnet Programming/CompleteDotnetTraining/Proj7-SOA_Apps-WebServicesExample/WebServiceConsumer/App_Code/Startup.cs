using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebServiceConsumer.Startup))]
namespace WebServiceConsumer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
