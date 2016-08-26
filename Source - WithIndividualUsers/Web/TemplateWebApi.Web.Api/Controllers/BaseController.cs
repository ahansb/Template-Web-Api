namespace TemplateWebApi.Web.Api.Controllers
{
    using System.Web.Http;
    using AutoMapper;
    using Infrastructure.Mappings;

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

