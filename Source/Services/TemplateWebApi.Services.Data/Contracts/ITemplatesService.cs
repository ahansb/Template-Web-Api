namespace TemplateWebApi.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TemplateWebApi.Data.Models;
    public interface ITemplatesService
    {
        int Add(Template template);

        IQueryable<Template> All();

        Template ById(int id);

        void Delete(Template id);

        void Dispose();

        void Update(Template template);
    }
}
