using RESEntity;
using RESInterface;
using RESRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESApp.Controllers
{
    [RoutePrefix("api/items")]
    public class ItemController : ApiController
    {
        private IItemRepository repo;

        public ItemController(IItemRepository repo)
        {
            this.repo = repo;
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll());
        }

        [Route("{id}", Name = "GetItem")]
        public IHttpActionResult Get(int id)
        {
            Item p = repo.Get(id);

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
        public IHttpActionResult Post(Item item)
        {
            repo.Insert(item);
            string url = Url.Link("GetItem", new { id = item.Id });
            return Created(url, item);
        }

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Item item, [FromUri]int id)
        {
            item.Id = id;
            repo.Update(item);
            return Ok(item);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(repo.Get(id));
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
// Cross Origin Resource Sharing (CORS)