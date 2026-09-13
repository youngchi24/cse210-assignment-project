public class Resume
{
    public string _name;
    public string _email;
    public string _phoneNumber;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name} Email: {_email} Phone Number: {_phoneNumber}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }
}