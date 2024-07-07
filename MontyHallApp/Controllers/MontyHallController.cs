using Microsoft.AspNetCore.Mvc;
using MontyHallApp.Model;
using MontyHallApp.Services;

namespace MontyHallApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MontyHallController: ControllerBase
    {
        private readonly MontyHallService _service;

        public MontyHallController()
        {
            _service = new MontyHallService();
        }

        [HttpGet("simulate")]
        public ActionResult<MontyHallModel> Simulate(int numberOfGames, bool changeDoor)
        {
            var result = _service.Simulate(numberOfGames, changeDoor);
            return Ok(result);
        }
    }
}
