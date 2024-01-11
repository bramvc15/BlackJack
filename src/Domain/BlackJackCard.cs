namespace Domain;

class BlackJackCard : Card
{
    public bool FaceUp { get; set; }
    public int Value { get; }

    public BlackJackCard(Suit suit, FaceValue faceValue): base(suit, faceValue)
    {
        
    }

    public void TurnCard()
    {
        throw new NotImplementedException();
    }

}