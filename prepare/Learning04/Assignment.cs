public class Assignment
{
    protected string _studentName;
    protected string _topic;


    public string GetStudent()
    {
        return _studentName;
    }

    public void SetStudent(string studentName)
    {
        _studentName = studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}