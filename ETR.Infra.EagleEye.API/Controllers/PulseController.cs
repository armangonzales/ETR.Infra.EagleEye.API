using ETR.Infra.EagleEye.API.Data;
using ETR.Infra.EagleEye.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETR.Infra.EagleEye.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PulseController : ControllerBase
    {
        private readonly PulseDbContext _context;

        public PulseController(PulseDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreatePulse(string computer, string taskid, string status)
        {
            var newPulseLogs = new PulseLog
            {
                ComputerName = computer,
                Date = DateTime.Now,
                TaskID = taskid,
                Status = status
            };
            var pulse=_context.PulseLogs.Add(newPulseLogs);
            _context.SaveChanges(); 
            return Ok(newPulseLogs);
        }
    }
}
