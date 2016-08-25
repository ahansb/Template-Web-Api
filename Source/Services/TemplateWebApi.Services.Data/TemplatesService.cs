namespace TemplateWebApi.Services.Data
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TemplateWebApi.Data.Common.Contracts;
    using TemplateWebApi.Data.Models;
    public class TemplatesService : ITemplatesService
    {
        private readonly IGenericRepository<Template> templates;
        public TemplatesService(IGenericRepository<Template> templatesRepo)
        {
            this.templates = templatesRepo;
        }

        public int Add(Template template)
        {
            this.templates.Add(template);
            this.templates.SaveChanges();
            return template.Id;
        }

        public IQueryable<Template> All()
        {
            return this.templates.All();
        }

        public Template ById(int id)
        {
            return this.templates.GetById(id);
        }

        public void Delete(Template template)
        {
            this.templates.Delete(template);
            this.templates.SaveChanges();
        }

        public void Dispose()
        {
            this.templates.Dispose();
        }

        public void Update(Template template)
        {
            this.templates.Update(template);

            this.templates.SaveChanges();
        }
    }
}
