using System.Diagnostics.Contracts;

namespace Command;  

public class InvokerCommand
{
    List<ICommand> _comands;

    public InvokerCommand()
    {
        _comands = new List<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        _comands.Add(command);
    }

    public void Execute()
    {
        _comands.ForEach(c => c.Execute());
    }

    public void Unexecute()
    {
        _comands.ForEach(c => c.Unexecute());
        _comands.Clear();
    } 

}