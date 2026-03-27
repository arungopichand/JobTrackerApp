using Microsoft.AspNetCore.Mvc;
using JobTrackerApp.Models;
using System.Reflection.Metadata.Ecma335;
using JobTrackerApp.Services;
namespace JobTrackerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;
        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public IActionResult GetAllJobs()
        {
            return Ok(_jobService.GetAllJobs());
        }
        [HttpGet("{id}")]
        public IActionResult GetJobById(int id)
        {
            var job = _jobService.GetJobById(id);
            if (job == null)
                return NotFound("Job not found");
           
            return Ok(job);
        }

        [HttpPost]
        public IActionResult CreateJob(Job job)
        {
            var createdJob = _jobService.CreateJob(job);
            return CreatedAtAction(nameof(GetJobById), new { id = createdJob.Id }, createdJob);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateJob(int id, Job job)
        {
            var updated = _jobService.UpdateJob(id, job);

            if (updated == null)
                return NotFound("Job not found");

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteJob(int id)
        {

            var deleted = _jobService.DeleteJob(id);

            if (!deleted)
                return NotFound("Job not found");

            return NoContent();
        }
   
    }

 }

