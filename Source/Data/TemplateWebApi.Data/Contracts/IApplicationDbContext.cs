namespace TemplateWebApi.Data.Contracts
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using TemplateWebApi.Data.Models;

    public interface IApplicationDbContext
    {
        IDbSet<Template> Templates { get; set; }
        
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
