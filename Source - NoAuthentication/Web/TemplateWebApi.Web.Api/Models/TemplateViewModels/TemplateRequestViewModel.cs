namespace TemplateWebApi.Web.Api.Models.TemplateViewModels
{
    using System.ComponentModel.DataAnnotations;
    using Data.Models;
    using Infrastructure.Mappings;

    public class TemplateRequestViewModel : IMapTo<Template>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }
    }
}