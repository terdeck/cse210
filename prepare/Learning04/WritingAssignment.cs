public class WritingAssignment : Assignment
{
    private string _title;


    // public WritingAssignment() : base()
    // {

    // }

    // public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    // {
        
    // } 

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

        public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}