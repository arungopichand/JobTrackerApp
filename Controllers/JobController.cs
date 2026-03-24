using Microsoft.AspNetCore.Mvc;
using JobTrackerApp.Models;
namespace JobTrackerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : Controller
    {
        private static List<Job> jobs = new List<Job>
    {
        new Job{ Id =1, Company = "Deloitee", Role = ".NET Developer", Status = "Applied" },
        new Job { Id=2, Company="EY", Role ="Power Platform Engineer", Status = "Interview"}

    };
        [HttpGet]
        public IActionResult GetAllJobs()
        {
            
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

        [HttpPost]
        public IActionResult CreateJob(Job job)
        {
            if (string.IsNullOrEmpty(job.Company))
            {
                return BadRequest("Company is required");
            }
            else
            {
                job.Id = jobs.Count + 1;
                jobs.Add(job);

                return Ok(job);
            }
        }
    }

 }

