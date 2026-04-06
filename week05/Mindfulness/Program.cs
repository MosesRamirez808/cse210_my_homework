using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        // The loop continues until the user explicitly chooses "4"
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start grounding activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run(); 
            }
            else if (choice == "3")
            {
                GroundingActivity activity = new GroundingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nGoodbye! Stay mindful.");
            }
            else
            {
                
                Console.WriteLine("\nInvalid selection. Please choose an option from 1 to 4.");
                Thread.Sleep(2000); 
            }
        }
    }
}