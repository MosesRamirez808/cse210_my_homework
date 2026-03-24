using System;

// CREATIVITY: My program ensures that it only selects words that are not already hidden, preventing the "HideRandomWords" method from wasting attempts on underscores.

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Setup the scripture
            Reference ref1 = new Reference("Proverbs", 3, 5, 6);
            Scripture scrip1 = new Scripture(ref1, "Trust in the Lord with all thine heart and lean not unto thine own understanding");

            string input = "";

            // 2. Main Loop
            while (input.ToLower() != "quit" && !scrip1.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scrip1.GetDisplayText());
                Console.WriteLine("\nPress enter to hide words or type 'quit' to finish:");
                
                input = Console.ReadLine();

                if (input.ToLower() != "quit")
                {
                    scrip1.HideRandomWords(3); // Hide 3 random words each time
                }
                
            }
            

            Console.WriteLine("\nGoodbye!");
        }
    }
}