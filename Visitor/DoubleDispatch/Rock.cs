namespace DoubleDispatch;

public class Rock : IPlayable
{
    public string Play(IPlayable playable)
    {
        return playable.PlayAgainst(this);
    }

    public string PlayAgainst(Rock rock)
    {
        return "Draw";
    }

    public string PlayAgainst(Paper paper)
    {
        return "Lose Rock";
    }

    public string PlayAgainst(Scissors scissors)
    {
        return "Won Rock";
    }

}
