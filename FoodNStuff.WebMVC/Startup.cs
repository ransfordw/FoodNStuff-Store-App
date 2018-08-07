using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodNStuff.WebMVC.Startup))]
namespace FoodNStuff.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
