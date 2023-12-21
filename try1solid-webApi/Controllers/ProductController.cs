using Microsoft.AspNetCore.Mvc;
using Solid.Core.Models;
using Solid.Core.Services;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public List<Product> Get()
        {
            return _productServices.GetListItems();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productServices.GetByIdItem(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _productServices.AddItem(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            _productServices.UpdateItem(id,value);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productServices.RemoveItem(id);
        }
    }
}
