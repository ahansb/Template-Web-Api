namespace TemplateWebApi.Data
{
    using Contracts;
    using System.Data.Entity;
    using Models;

    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext()
          : base("DefaultConnection")
        {
        }

        public IDbSet<Template> Templates { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}

