namespace Domain;

class Card
{
    public FaceValue FaceValue {get; }
    public Suit Suit { get; }


    public Card(Suit suit, FaceValue faceValue)
    {
        FaceValue = faceValue;
        suit = suit;
    }

}

class BlackJack
{
    public bool FaceDown;
    public bool FaceUp;
    private Deck _deck;

    public Hand PlayerHand { get; }

    public Hand DealerHand { get; }
    public GameState GameState { get; private set; }

    public BlackJack()
    {
        

    }
    public BlackJack(Deck deck)
    {
        _deck = deck;
    }
    private void Deal()
    {
        throw new NotImplementedException();
    }
    public void PassToDealer()
    {
        throw new NotImplementedException();
    }
    public string GameSummary()
    {
        throw new NotImplementedException();
    }
    public void GivePlayerAnotherCard()
    {
        throw new NotImplementedException();
    }
    private void AddCardToHand(Hand hand, bool faceUp)
    {
        throw new NotImplementedException();
    }
    private void AdjustGameState(GameState? gameState = null)
    {
        throw new NotImplementedException();
    }
    private void LetDealerFinalize()
    {
        throw new NotImplementedException();
    }
}