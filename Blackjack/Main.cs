namespace Blackjack
{
    public class Card : ICard
    {
        public Rank Rank { get; private set; }

        public Card(Rank rank)
        {
            Rank = rank;
        }

        public Rank GetRank()
        {
            return Rank;
        }
    }

    public class Hand : IHand
    {
        private readonly List<ICard> _cards;

        public IReadOnlyList<ICard> Cards => _cards;

        public Hand(IEnumerable<ICard> cards)
        {
            _cards = cards.ToList();
        }

        public void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public int GetPoints()
        {
            int total = 0;
            int aceCount = 0;

            foreach (var card in _cards)
            {
                if (card.GetRank() == Rank.Ace)
                {
                    total += 1;
                    aceCount++;
                }
                else
                {
                    total += BlackjackScoring.GetValue(card.GetRank());
                }
            }

            while (aceCount > 0 && total + 10 <= BlackjackScoring.BlackjackCore)
            {
                total += 10;
                aceCount--;
            }

            return total;
        }

        public bool IsBlackJack()
        {
            return _cards.Count() == 2 && GetPoints() == BlackjackScoring.BlackjackCore;
        }

        public bool IsBusted()
        {
            return GetPoints() > BlackjackScoring.BlackjackCore;
        }
    }

    public interface ICard
    {
        Rank GetRank();
    }

    public interface IHand
    {
        void AddCard(ICard card);
        int GetPoints();
        bool IsBlackJack();
        bool IsBusted();
    }

    public static class BlackjackScoring
    {
        public static int BlackjackCore = 21;

        public static int GetValue(Rank rank)
        {
            switch (rank)
            {
                case Rank.Two: return 2;
                case Rank.Three: return 3;
                case Rank.Four: return 4;
                case Rank.Five: return 5;
                case Rank.Six: return 6;
                case Rank.Seven: return 7;
                case Rank.Eight: return 8;
                case Rank.Nine: return 9;
                case Rank.Ten:
                case Rank.Jack:
                case Rank.Queen:
                case Rank.King:
                    return 10;
                case Rank.Ace:
                    return 1;
                default:
                    throw new ArgumentOutOfRangeException(nameof(rank), $"Invalid rank {rank}.");
            }
        }
    }


    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
