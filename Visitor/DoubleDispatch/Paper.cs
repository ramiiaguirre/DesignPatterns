namespace DoubleDispatch;

public class Paper : IPlayable
{
    public string Play(IPlayable playable)
    {
        return playable.PlayAgainst(this);
    }

    public string PlayAgainst(Rock rock)
    {
        return "Won Paper";
    }

    public string PlayAgainst(Paper paper)
    {
        return "Draw";
    }

    public string PlayAgainst(Scissors scissors)
    {
        return "Lose Paper";
    }
}
