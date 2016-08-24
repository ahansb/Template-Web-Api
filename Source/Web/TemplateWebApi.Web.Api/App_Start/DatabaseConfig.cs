namespace TemplateWebApi.Web.Api
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;
    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            ApplicationDbContext.Create().Database.Initialize(true);
        }
    }
}