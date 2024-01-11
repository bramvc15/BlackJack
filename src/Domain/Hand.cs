namespace Domain;

class Hand
{
    public IEnumerable<BlackJackCard> Cards { get; }
    public int NrOfCards { get; }
    public int Value { get; }
    private IList<BlackJackCard> _cards = new List<BlackJackCard>();

    public Hand()
    {

    }

    public void AddCard(BlackJackCard card)
    {
        throw new NotImplementedException();
    }
    public void TurnAllCardsFaceUp()
    {
        throw new NotImplementedException();
    }
    private int CalculateValue()
    {
        throw new NotImplementedException();
    }
}