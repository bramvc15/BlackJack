namespace Domain;

class Deck
{
    protected IList<BlackJackCard> _cards = new List<BlackJackCard>();
    private Random _random;

    public Deck()
    {
    }

    public BlackJackCard Draw()
    {
        throw new NotImplementedException();
    }
    private void Shuffle()
    {
        throw new NotImplementedException();
    }
}