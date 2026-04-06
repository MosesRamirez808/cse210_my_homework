public class GroundingActivity : Activity
{
    private List<string> _senses;
    private List<string> _instructions;

    public GroundingActivity() : base("Grounding Activity", "This activity helps you ground yourself by focusing on your five senses to bring you into the present moment.")
    {
        _senses = new List<string> { "Sight", "Touch", "Hearing", "Smell", "Taste" };
        _instructions = new List<string> 
        { 
            "5 things you can see", 
            "4 things you can touch", 
            "3 things you can hear", 
            "2 things you can smell", 
            "1 thing you can taste" 
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _senses.Count; i++)
        {
            Console.WriteLine($"\nFocus on {_senses[i]}:");
            Console.WriteLine($"Identify {_instructions[i]}.");
            ShowSpinner(7); // Gives the user time to actually find the items
        }

        DisplayEndingMessage();
    }
}