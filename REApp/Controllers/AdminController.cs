using RESEntity;
using RESInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace REApp.Controllers
{
    [RoutePrefix("api/admins")]
    public class AdminController : ApiController
    {
        // GET: Admin
        private IAdminRepository repo;

        public AdminController(IAdminRepository repo)
        {
            this.repo = repo;
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll());
        }

        [Route("{id}", Name = "GerAdmin")]
        public IHttpActionResult Get(int id)
        {
            Admin p = repo.Get(id);

            //return cat == null ? StatusCode(HttpStatusCode.NoContent) : Ok(cat);

            if (p == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            else
            {
                return Ok(p);
            }

        }

        [Route("")]
        public IHttpActionResult Post(Admin admin)
        {
            repo.Insert(admin);
            string url = Url.Link("GetAdmin", new { id = admin.AdminId });
            return Created(url, admin);
        }

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Admin admin, [FromUri]int id)
        {
            admin.AdminId = id;
            repo.Update(admin);
            return Ok(admin);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(repo.Get(id));
            return StatusCode(HttpStatusCode.NoContent);
        }



    }
}