using System.Text;

public class DisplaySimplePresentation : IDisplayPresentation
{
    public string GetHeader(string name)
    {
        var dataHeader = new StringBuilder();
        dataHeader.Append("My name is " + name);
        dataHeader.AppendLine();
        return dataHeader.ToString();
    }

    public string GetContent(string data)
    {
        var dataContent = new StringBuilder();
        dataContent.Append(data);
        dataContent.AppendLine();
        dataContent.Append("Presentation date: " + DateTime.Now.ToShortDateString());
        return dataContent.ToString();
    }
}