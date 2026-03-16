public class Entry
{
    public string _date;
    public string _time;
    public string _prompt;
    public string _entryText;
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}