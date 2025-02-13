namespace Blackjack
{
    public class Hand : IHand
    {
        private List<ICard> _cards;

        public Hand(ICard firstCard, ICard secondCard)
        {
            _cards = new List<ICard>() { firstCard, secondCard };
        }

        public void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public int GetPoints()
        {
            var points = 0;
            var aceCount = 0;

            foreach (var card in _cards)
            {
                if (card.IsAce())
                {
                    points += 11;
                    aceCount++;
                }
                else if (card.IsFaceValue())
                {
                    points += 10;
                }
                else
                {
                    points += card.GetPoints();
                }
            }

            while (points > 21 && aceCount > 0)
            {
                points -= 10;
                aceCount--;
            }

            return points;
        }

        private bool HasAce => _cards.Any(x => x.IsAce());

        public bool IsBlackJack()
        {
            if (_cards.Count != 2) return false;

            var points = GetPoints();
            var hasTenValueCard = _cards.Any(x => x.IsAce()) && _cards.Any(x => x.GetPoints() == 10);

            return points == 21 && HasAce && hasTenValueCard;
        }

        public bool IsBusted()
        {
            return GetPoints() > 21;
        }
    }
}