using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthWithIdentity.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private AppDbContext _dbContext;

        public ProductsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/products
        [HttpGet]
        public IEnumerable<string> Getproducts()
        {
          
            return new string[] { "value1", "value2" };
        }

        // GET api/products/dubai-city-tour
        [HttpGet("{id}")]
        public string GetProduct(string id)
        {
            return "value";
        }


        //GET api/products/int/1
        [HttpGet("int/{id:int}")]
        public string GetProduct(int id)
        {
            return "value";
        }

        //POST api/products
        [HttpPost]
        public string PostReq(ViewModels.ProductViewModel product)
        {
            return product.Name;
        }
        // POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
