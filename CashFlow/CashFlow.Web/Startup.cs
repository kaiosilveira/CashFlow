using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CashFlow.Web.Startup))]
namespace CashFlow.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
