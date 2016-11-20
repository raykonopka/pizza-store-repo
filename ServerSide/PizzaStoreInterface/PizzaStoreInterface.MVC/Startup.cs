using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaStoreInterface.MVC.Startup))]
namespace PizzaStoreInterface.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
