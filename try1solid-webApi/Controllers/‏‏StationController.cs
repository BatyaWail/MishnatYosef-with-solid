using Microsoft.AspNetCore.Mvc;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace try1solid_webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationServices _stationServices;

        public StationController(IStationServices stationServices)
        {
            _stationServices = stationServices;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public List<Station> Get()
        {
            return _stationServices.GetItem();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Station Get(int id)
        {
            return _stationServices.GetByIdItem();
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Station value)
        {
            _stationServices.AddItem();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Station value)
        {
            _stationServices.UpdateItem();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _stationServices.RemoveItem();
        }
    }
}
