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
    [RoutePrefix("api/users")]

    public class UserController : ApiController
    {
        // GET: User
        private IUserRepository repo;

        public UserController(IUserRepository repo)
        {
            this.repo = repo;
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll());
        }

        [Route("{id}", Name = "GerUser")]
        public IHttpActionResult Get(int id)
        {
            User p = repo.Get(id);

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
        public IHttpActionResult Post(User user)
        {
            repo.Insert(user);
            string url = Url.Link("GetUser", new { id = user.UserId });
            return Created(url, user);
        }

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]User user, [FromUri]int id)
        {
            user.UserId = id;
            repo.Update(user);
            return Ok(user);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(repo.Get(id));
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}