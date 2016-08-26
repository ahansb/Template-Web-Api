namespace TemplateWebApi.Web.Api.Models.TemplateViewModels
{
    using Data.Models;
    using Infrastructure.Mappings;

    public class TemplateResponseViewModel : IMapFrom<Template>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Text { get; set; }
    }
}