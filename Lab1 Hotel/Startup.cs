using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1_Hotel.Startup))]
namespace Lab1_Hotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
