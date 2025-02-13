namespace Blackjack
{
    public interface ICard
    {
        int GetPoints();
        bool IsAce();
        bool IsFaceValue();
    }
}
