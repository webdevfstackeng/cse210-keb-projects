public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Member method for showing company name.
    public void DisplayJobInformation()
    {
        Console.WriteLine(_company);
    }

    // Member method for showing job details.
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

