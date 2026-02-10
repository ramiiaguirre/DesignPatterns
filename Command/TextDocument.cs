namespace Command;

//Receiver
public class TextDocument
{
    string _dataContent = string.Empty;
    string _title = "Title";

    public string GetDataContent()
    {
        return _dataContent;
    }

    public void SetDataContent(string data)
    {
        _dataContent = data;
    }

    public void SetMayus()
    {
        _dataContent = _dataContent.ToUpper();
    }
}