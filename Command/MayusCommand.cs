namespace Command;

//ConcreteCommand
public class MayusCommand : ICommand
{
    TextDocument _document;
    TextDocument? _documentBackup;
    public MayusCommand(TextDocument document)
    {
        _document = document;
    }

    public bool Execute()
    {
        Backup();
        _document.SetMayus();
        return true;
    }
    public bool Unexecute()
    {
        if(_documentBackup != null)
        {
            _document.SetDataContent(_documentBackup.GetDataContent());
            return true;
        }
        return false;
    }

    void Backup()
    {
        _documentBackup = new TextDocument();
        _documentBackup.SetDataContent(_document.GetDataContent());
    }
}