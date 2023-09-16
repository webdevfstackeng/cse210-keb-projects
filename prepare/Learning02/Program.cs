using System;

class Program
{
    static void Main(string[] args)
    {
        // Adding job1 to the list of jobs in the resume object.
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2022;
        job1._endYear = 2024;

        // Adding job2 to the list of jobs in the resume object.
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2021;
        job2._endYear = 2025;

        // Instantiation of object 'resume' of type Resume
        // and using the dot notation to assign the name to _name variable. 

        Resume resume = new Resume();
        resume._name = "Kgotla Boabilwe";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Call for Resume class method         
        resume.DisplayResumeDetails();
    }
}