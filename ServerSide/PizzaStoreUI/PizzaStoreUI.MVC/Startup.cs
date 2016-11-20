using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaStoreUI.MVC.Startup))]
namespace PizzaStoreUI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
