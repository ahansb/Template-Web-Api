namespace TemplateWebApi.Data.Models
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    public class ApplicationUser : IdentityUser
    {
        private ICollection<Template> templates;

        public ApplicationUser():base()
        {
            this.Templates = new HashSet<Template>();
        }

        public virtual ICollection<Template> Templates { get { return this.templates; } set { this.templates = value; } }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
