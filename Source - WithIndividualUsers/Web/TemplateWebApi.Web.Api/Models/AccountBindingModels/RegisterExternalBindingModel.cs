namespace TemplateWebApi.Web.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}