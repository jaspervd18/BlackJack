﻿namespace Domain;

public class BlackJackCard
{
    public bool FaceUp { get; set; }

    public int Value { get; }

    public BlackJackCard(Suit suit, FaceValue faceValue)
    {
        throw new NotImplementedException();
    }

    public void TurnCard()
    {
        throw new NotImplementedException();
    }
}