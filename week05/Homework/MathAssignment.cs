namespace Homework;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Use : base() to pass "Moe Ramirez" and the topic up to the parent
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        // Customizing the output format to be a bit cleaner
        return $"[Module: {_textbookSection}] -> Tasks: {_problems}";
    }
}