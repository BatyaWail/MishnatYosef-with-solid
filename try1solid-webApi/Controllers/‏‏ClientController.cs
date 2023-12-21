using Microsoft.AspNetCore.Mvc;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace try1solid_webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientServices _clientServices;


        public ClientController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public List<Client> Get()
        {
            return _clientServices.GetItem();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public  Client Get(int id)
        {
            return _clientServices.GetByIdItem();
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Client value)
        {
            _clientServices.AddItem();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client value)
        {
            _clientServices.UpdateItem();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clientServices.RemoveItem();
        }
    }
}
