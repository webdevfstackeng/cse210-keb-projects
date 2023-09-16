public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Function for displaying resume and job details.
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}