public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startDate;
    public string _endDate;

    public Job(string jobTitle, string company, string startDate, string endDate)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startDate = startDate;
        _endDate = endDate;
    }

    public void DisplayJob()
    {
        Console.WriteLine($"Job Title: {_jobTitle} Company: {_company} Start Date: {_startDate} End Date: {_endDate}");
    }
}