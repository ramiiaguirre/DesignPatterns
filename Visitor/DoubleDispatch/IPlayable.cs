namespace DoubleDispatch;

//Visitor
public interface IPlayable
{
    public string Play(IPlayable playable);
    public string PlayAgainst(Rock rock);
    public string PlayAgainst(Paper paper);
    public string PlayAgainst(Scissors scissors);
}
