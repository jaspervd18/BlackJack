namespace Domain;

public class BlackJack
{
    public bool FaceDown;
    public bool FaceUp;
    private Deck _deck;
    public Hand PlayerHand { get; }
    public Hand DealerHand { get; }

    public GameState GameState { get; private set; }

    public BlackJack()
    {
        throw NotImplementedException();
    }

    public BlackJack(Deck deck)
    {
        _deck = deck;
    }

    private void Deal()
    {
        throw NotImplementedException();
    }

    public void PassToDealer()
    {
        throw NotImplementedException();
    }

    public String GameSummary()
    {
        throw NotImplementedException();
    }

    public void GivePlayerAnotherCard()
    {
        throw NotImplementedException();
    }

    private void AddCardToHand(Hand hand, bool faceUp)
    {
        throw NotImplementedException();
    }

    private void AdjustGameSize(GameState? gameState = null)
    {
        throw NotImplementedException();
    }

    private void LetDealerFinalize()
    {
        throw NotImplementedException();
    }

    private Exception NotImplementedException()
    {
        throw new NotImplementedException();
    }
}

