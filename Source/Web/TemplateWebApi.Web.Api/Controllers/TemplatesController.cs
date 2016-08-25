namespace TemplateWebApi.Web.Api.Controllers
{
    using Microsoft.AspNet.Identity;
    using Services.Data.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Description;
    using TemplateWebApi.Data;
    using TemplateWebApi.Data.Models;

    [Authorize]
    public class TemplatesController : ApiController
    {
        private ITemplatesService templates;

        public TemplatesController(ITemplatesService templatesService)
        {
            this.templates = templatesService;
        }

        // GET: api/Templates
        public IQueryable<Template> GetTemplates()
        {
            return this.templates.All();
        }

        // GET: api/Templates/5
        [ResponseType(typeof(Template))]
        public IHttpActionResult GetTemplate(int id)
        {
            Template template = this.templates.ById(id);
            if (template == null)
            {
                return NotFound();
            }

            return Ok(template);
        }

        // PUT: api/Templates/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTemplate(int id, Template template)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != template.Id)
            {
                return BadRequest();
            }

            this.templates.Update(template);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Templates
        [ResponseType(typeof(Template))]
        public IHttpActionResult PostTemplate(Template template)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            template.UserId= this.User.Identity.GetUserId();

            var templateId = this.templates.Add(template);

            return CreatedAtRoute("DefaultApi", new { id = templateId }, template);
        }

        // DELETE: api/Templates/5
        [ResponseType(typeof(Template))]
        public IHttpActionResult DeleteTemplate(int id)
        {
            Template template = this.templates.ById(id);
            if (template == null)
            {
                return NotFound();
            }

            this.templates.Delete(template);
            
            return Ok(template);
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