using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechGadgetRental.Startup))]
namespace TechGadgetRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
