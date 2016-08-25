namespace TemplateWebApi.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Template
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
