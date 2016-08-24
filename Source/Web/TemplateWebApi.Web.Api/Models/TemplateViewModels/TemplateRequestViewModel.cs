namespace TemplateWebApi.Web.Api.Models.TemplateViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class TemplateRequestViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }

        public string UserId { get; set; }
    }
}