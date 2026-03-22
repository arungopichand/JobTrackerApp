using Microsoft.AspNetCore.Mvc;
using JobTrackerApp.Models;
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
            var job = new Job
            {
                Id = id,
                Company = "Sample Company",
                Role = "Sample Role",
                Status = "Applied"
            };
            return Ok(job);
        }
    }

 }

