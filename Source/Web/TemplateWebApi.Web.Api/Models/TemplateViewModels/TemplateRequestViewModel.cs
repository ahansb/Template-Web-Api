namespace TemplateWebApi.Web.Api.Models.TemplateViewModels
{
    using System.ComponentModel.DataAnnotations;
    using Data.Models;
    using Infrastructure.Mappings;
    using System.ComponentModel.DataAnnotations.Schema;
    public class TemplateRequestViewModel : IMapTo<Template>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}