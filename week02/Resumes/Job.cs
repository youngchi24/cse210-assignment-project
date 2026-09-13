public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startDate;
    public string _endDate;

    public void DisplayJob()
    {
        Console.WriteLine($"Job Title: {_jobTitle} Company: {_company} Start Date: {_startDate} End Date: {_endDate}");
    }
}