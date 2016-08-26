using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TemplateWebApi.Web.Api.Startup))]

namespace TemplateWebApi.Web.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
