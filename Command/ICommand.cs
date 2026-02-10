namespace Command;

public interface ICommand
{
    public bool Execute();
    public bool Unexecute();
}