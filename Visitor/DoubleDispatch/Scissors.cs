namespace DoubleDispatch;

public class Scissors : IPlayable
{
    public string Play(IPlayable playable)
    {
        return playable.PlayAgainst(this);
    }

    public string PlayAgainst(Rock rock)
    {
        return "Lose Scissors";
    }

    public string PlayAgainst(Paper paper)
    {
        return "Won Scissors";
    }

    public string PlayAgainst(Scissors scissors)
    {
        return "Draw";
    }
}