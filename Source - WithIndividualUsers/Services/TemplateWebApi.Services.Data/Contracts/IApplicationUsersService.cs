namespace TemplateWebApi.Services.Data.Contracts
{
    using TemplateWebApi.Data.Models;

    public interface IApplicationUsersService
    {
        ApplicationUser ById(string id);
    }
}
