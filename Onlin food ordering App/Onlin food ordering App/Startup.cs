using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Onlin_food_ordering_App.Startup))]
namespace Onlin_food_ordering_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
