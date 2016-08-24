namespace TemplateWebApi.Web.Api.Models.TemplateViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class TemplateResponseViewModel
    {
        public string Name { get; set; }
        
        public string Text { get; set; }

        public string UserEmail { get; set; }
    }
}