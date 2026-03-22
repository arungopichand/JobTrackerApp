using Microsoft.AspNetCore.Mvc;

namespace JobTrackerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : Controller
    {
        [HttpGet]
        public IActionResult GetAllJobs()
        {
            var jobs = new List<string>
            {
                "Deloitee - .Net Developer",
                "EY - Power Platform Engineer"
            };
            return Ok(jobs);
        }
        [HttpGet("{id}")]
        public IActionResult GetJobById(int id)
        {
            return Ok($"Job with ID:{id}");
        }

    }
}
