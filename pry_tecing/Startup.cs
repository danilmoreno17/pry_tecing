using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pry_tecing.Startup))]
namespace pry_tecing
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
