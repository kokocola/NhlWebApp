using Lib.Helpers;
using Lib.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NhlDAL;

namespace NhlApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ControllerBase
    {
        private INhlService nhlService;
        private readonly ILogger<TeamsController> _logger;

        public TeamsController(ILogger<TeamsController> logger, INhlService service)
        {
            _logger = logger;
            nhlService = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Calling Get All Teams!!!");
            _logger.LogError("Calling Get All Teams Error!!!");
            var item = ApiUtility.SerializeObject(nhlService.GetAllTeams());
            if (item == null)
            { 
                return NotFound();
            }
            return Ok(item);
        }

        // GET: api/Teams/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var item = nhlService.GetTeamById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
