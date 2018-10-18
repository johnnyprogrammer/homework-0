using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(tiengvietService.Startup))]

namespace tiengvietService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}