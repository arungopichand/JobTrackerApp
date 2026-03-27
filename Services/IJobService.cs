using JobTrackerApp.Models;

namespace JobTrackerApp.Services
{
    public interface IJobService
    {
        List<Job> GetAllJobs();
        Job GetJobById(int id);
        Job CreateJob(Job job);
        Job UpdateJob(int id, Job job);
        bool DeleteJob(int id);
    }
}
