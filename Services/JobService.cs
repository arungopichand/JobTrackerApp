using JobTrackerApp.Models;

namespace JobTrackerApp.Services
{
    public class JobService : IJobService
    {
        private static List<Job> jobs = new List<Job>
        {
            new Job { Id = 1, Company = "Deloitte", Role = ".NET Developer", Status = "Applied" },
            new Job { Id = 2, Company = "EY", Role = "Power Platform Engineer", Status = "Interview" }
        };

        public List<Job> GetAllJobs()
        {
            return jobs;
        }

        public Job GetJobById(int id)
        {
            return jobs.FirstOrDefault(j => j.Id == id);
        }

        public Job CreateJob(Job job)
        {
            job.Id = jobs.Count + 1;
            jobs.Add(job);
            return job;
        }

        public Job UpdateJob(int id, Job updatedJob)
        {
            var job = jobs.FirstOrDefault(j => j.Id == id);

            if (job == null) return null;

            job.Company = updatedJob.Company;
            job.Role = updatedJob.Role;
            job.Status = updatedJob.Status;

            return job;
        }

        public bool DeleteJob(int id)
        {
            var job = jobs.FirstOrDefault(j => j.Id == id);

            if (job == null) return false;

            jobs.Remove(job);
            return true;
        }
    }
}