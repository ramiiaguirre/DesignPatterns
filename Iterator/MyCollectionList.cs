namespace Iterator;
public class MyCollectionList<T> : IList<T>
{
    private Node<T>? _headNode;
    private int _size;

    public MyCollectionList()
    {
        _headNode = null;
        _size = 0;
    }

    public Node<T>? GetHeadNode() => _headNode;

    public void Append(T element)
    {
        Node<T> newNode = new Node<T>(element);

        if (_headNode == null)
        {
            _headNode = newNode;
        }
        else
        {
            Node<T> actual = _headNode;
            while (actual.NextNode != null)
            {
                actual = actual.NextNode;
            }
            actual.NextNode = newNode;
        }
        _size++;
    }

    public int Size() => _size;

    public IIterator<T> CreateIterator()
    {
        return new ListIterator<T>(this);
    }


}