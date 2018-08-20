using RESInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using RESEntity;
using System.Net;

namespace REApp.Controllers
{
    [RoutePrefix("api/categories")]
    public class CategoryController : ApiController
    {
        // GET: Category
        ICategoryRepository repo;
        IItemRepository irepo;
        public CategoryController(ICategoryRepository repo, IItemRepository irepo)
        {
            this.repo = repo;
            this.irepo = irepo;
        }
        [HttpGet][Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll());
        }

        [Route("{id}", Name = "GetCategory")]
        public IHttpActionResult Get(int id)
        {
            Category cat = repo.Get(id);

            //return cat == null ? StatusCode(HttpStatusCode.NoContent) : Ok(cat);

            if (cat == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            else
            {
                return Ok(cat);
            }

        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Insert(Category category)
        {
            repo.Insert(category);
            string url = Url.Link("GetCategory", new { id = category.Id });
            return Created(url, category);
        }

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Category category, [FromUri]int id)
        {
            category.Id = id;
            repo.Update(category);
            return Ok(category);
        }
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(repo.Get(id));
            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("{id}/products")]
        public IHttpActionResult GetProducts(int id)
        {
            return Ok(irepo.GetItemsByCategory(id));
        }

    }
}