namespace TemplateWebApi.Services.Data
{
    using Contracts;
    using TemplateWebApi.Data.Models;
    using TemplateWebApi.Data.Common.Contracts;

    public class ApplicationUsersService : IApplicationUsersService
    {
        private readonly IGenericRepository<ApplicationUser> users;

        public ApplicationUsersService(IGenericRepository<ApplicationUser> usersRepo)
        {
            this.users = usersRepo;
        }

        public ApplicationUser ById(string id)
        {
            return this.users.GetById(id);
        }
    }
}
