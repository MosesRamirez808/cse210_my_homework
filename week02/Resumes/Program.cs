using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Bayer";
        job1._jobTitle = "HSE Technician";
        job1._startYear = 2024;
        job1._endYear = DateTime.Now.Year;

        Job job2 = new Job();
        job2._company = "Marriott";
        job2._jobTitle = "Manager";
        job2._startYear = 1997;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Moses Ramirez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}