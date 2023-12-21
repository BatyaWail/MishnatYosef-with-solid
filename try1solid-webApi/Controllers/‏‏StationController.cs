
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Solid.Core.Models;
using Solid.Core.Services;

namespace Solid.Api.Controllers
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
            return _stationServices.GetListItems();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Station Get(int id)
        {
            return _stationServices.GetByIdItem(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Station value)
        {
            _stationServices.AddItem(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Station value)
        {
            _stationServices.UpdateItem(id,value);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _stationServices.RemoveItem(id);
        }
    }
}
