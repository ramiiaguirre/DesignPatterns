namespace Iterator;

public interface IList<T>
{
    IIterator<T> CreateIterator();
    int Size();
    void Append(T element);

}