namespace Iterator;

public interface IIterator<T>
{
    public T Next();
    public bool IsDone();
}