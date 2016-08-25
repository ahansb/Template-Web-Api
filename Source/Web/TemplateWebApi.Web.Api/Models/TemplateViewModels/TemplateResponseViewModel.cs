namespace TemplateWebApi.Web.Api.Models.TemplateViewModels
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class TemplateResponseViewModel : IMapFrom<Template>, IHaveCustomMappings
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Text { get; set; }

        public string UserEmail { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Template, TemplateResponseViewModel>()
                            .ForMember(x => x.UserEmail, opt => opt.MapFrom(x => x.User.Email));
        }
    }
}