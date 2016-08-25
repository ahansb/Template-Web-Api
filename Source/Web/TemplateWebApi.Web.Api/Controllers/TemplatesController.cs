namespace TemplateWebApi.Web.Api.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Http;

    using Microsoft.AspNet.Identity;
    using Services.Data.Contracts;
    using Data.Models;
    using Models.TemplateViewModels;

    [Authorize]
    public class TemplatesController : BaseController
    {
        private ITemplatesService templates;
        private IApplicationUsersService users;

        public TemplatesController(ITemplatesService templatesService, IApplicationUsersService usersService)
        {
            this.templates = templatesService;
            this.users = usersService;
        }

        // GET: api/Templates
        public IHttpActionResult GetTemplates()
        {
            var templates = this.templates.All().ToList();
            var viewTemplates = this.Mapper.Map<IEnumerable<TemplateResponseViewModel>>(templates);

            return this.Ok(viewTemplates);
        }

        // GET: api/Templates/5
        public IHttpActionResult GetTemplate(int id)
        {
            var template = this.templates.ById(id);
            var viewTemplate = this.Mapper.Map<TemplateResponseViewModel>(template);

            if (viewTemplate == null)
            {
                return NotFound();
            }

            return Ok(viewTemplate);
        }

        // PUT: api/Templates/5
        public IHttpActionResult PutTemplate(int id, TemplateRequestViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = this.User.Identity.GetUserId();
            model.UserId = userId;
            //model.User = this.users.ById(userId);
            var template = this.Mapper.Map<Template>(model);
            this.templates.Update(template);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Templates
        public IHttpActionResult PostTemplate(TemplateRequestViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = this.User.Identity.GetUserId();
            model.UserId = userId;

            var template = this.Mapper.Map<Template>(model);
            var templateId = this.templates.Add(template);

            var addedTemplate = this.templates.ById(templateId);
            addedTemplate.User = this.users.ById(userId);
            var viewModel = this.Mapper.Map<TemplateResponseViewModel>(addedTemplate);

            return CreatedAtRoute("DefaultApi", new { id = templateId }, viewModel);
        }

        // DELETE: api/Templates/5
        public IHttpActionResult DeleteTemplate(int id)
        {
            var template = this.templates.ById(id);
            if (template == null)
            {
                return NotFound();
            }

            this.templates.Delete(template);

            var viewModel = this.Mapper.Map<TemplateResponseViewModel>(template);

            return Ok(viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.templates.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}