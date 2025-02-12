namespace Blackjack
{
    public interface IHand
    {
        void AddCard(ICard card);
        int GetPoints();
        bool IsBlackJack();
        bool IsBusted();
    }
}
