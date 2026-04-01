namespace Homework;

public class Assignment
{
   
    private string _studentName;
    private string _topic;

    
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName; // e.g., "Moses L Ramirez"
        _topic = topic;             // e.g., "Python Programming" or "Kombucha Chemistry"
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        // Adding a little Hawaiian flair to the summary format
        return $"{_studentName} (Kihei, HI) - Topic: {_topic}";
    }
}