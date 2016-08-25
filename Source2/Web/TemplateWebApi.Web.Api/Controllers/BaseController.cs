namespace TemplateWebApi.Web.Api.Controllers
{
    using AutoMapper;
    using Infrastructure.Mappings;
    using System.Web.Http;

    public abstract class BaseController : ApiController
    {

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}

