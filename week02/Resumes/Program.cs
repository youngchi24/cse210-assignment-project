using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "ABC Company";
        job1._startDate = "2020-01-01";
        job1._endDate = "2023-12-31";

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "XYZ Company";
        job2._startDate = "2021-06-01";
        job2._endDate = "2024-05-31";

        job1.DisplayJob();
        job2.DisplayJob();
    }
}