using System;

namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        // 1. Test the base Assignment class
        // Using your Python enrollment as a real-world example
        Assignment basicTask = new Assignment("Moe Ramirez", "Python Programming");
        Console.WriteLine("--- Base Assignment Summary ---");
        Console.WriteLine(basicTask.GetSummary());
        Console.WriteLine();

        // 2. Test the MathAssignment class
        // Using your Programming Hub studies as a focus
        MathAssignment mathTask = new MathAssignment("Moe Ramirez", "Binary Logic", "Module 3.2", "8-15, 21");
        Console.WriteLine("--- Math Assignment Details ---");
        Console.WriteLine(mathTask.GetSummary()); // 
        Console.WriteLine(mathTask.GetHomeworkList());
        Console.WriteLine();

        // 3. Test the WritingAssignment class
        // Using your Genealogy research interests
        WritingAssignment writingTask = new WritingAssignment("Moe Ramirez", "Genealogy", "The Ramirez Lineage: A MyHeritage Study");
        Console.WriteLine("--- Writing Assignment Details ---");
        Console.WriteLine(writingTask.GetSummary()); // This is also inherited!
        Console.WriteLine(writingTask.GetWritingInformation());
        Console.WriteLine();
    }
}