namespace Iterator;

public class ListIterator<T> : IIterator<T>
{
    readonly  MyCollectionList<T> _list;
    private Node<T>? _currenteNode;
    public ListIterator(MyCollectionList<T> list)
    {
        _list = list;
        _currenteNode = list.GetHeadNode();
    }

    public bool IsDone()
    {
        if (_currenteNode == null)
        {
            _currenteNode = _list.GetHeadNode();
            return true;
        }
        return false;
    }

    public T Next()
    {
        if (IsDone())
            throw new InvalidOperationException("There are not more elements.");

        T element = _currenteNode!.Element;
        _currenteNode = _currenteNode.NextNode;
        return element;
    }
}