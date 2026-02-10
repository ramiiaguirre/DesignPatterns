namespace Iterator;
public class Node<T>
{
    public T Element { get; set; }
    public Node<T>? NextNode { get; set; }

    public Node(T element)
    {
        Element = element;
        NextNode = null;
    }
}