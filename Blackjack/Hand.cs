namespace Blackjack
{
    public class Hand : IHand
    {
        private ICard firstCard;
        private ICard secondCard;

        public Hand(ICard firstCard, ICard secondCard)
        {
            this.firstCard = firstCard;
            this.secondCard = secondCard;
        }

        public void AddCard(ICard card)
        {
            throw new NotImplementedException();
        }

        public int GetPoints()
        {
            return firstCard.GetPoints() + secondCard.GetPoints();
        }

        public bool IsBlackJack()
        {
            throw new NotImplementedException();
        }

        public bool IsBusted()
        {
            throw new NotImplementedException();
        }
    }
}