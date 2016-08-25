namespace TemplateWebApi.Web.Api
{
    using System.Reflection;
    using System.Web.Http;
    using System.Web.Mvc;
    using Infrastructure.Mappings;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DatabaseConfig.Initialize();

            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(Assembly.GetExecutingAssembly());
        }
    }
}
