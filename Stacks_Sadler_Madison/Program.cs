// See https://aka.ms/new-console-template for more information
using Stacks_Sadler_Madison;

// Creates a Card array called myCardsArray
// Creates eight card objects
Card[] myCardsArray = new Card[]
{
    new Card("Ace", "Spades"),
    new Card("Jack", "Clubs"),
    new Card("Queen", "Diamonds"),
    new Card("King", "Hearts"),
    new Card("3", "Diamonds"),
    new Card("5", "Spades"),
    new Card("2", "Hearts"),
    new Card("10", "Clubs")
};

// Creates a Card stack called startingDeck
Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

// Prints to console "Cards in deck:"
Console.WriteLine("Cards in Deck:");
// Uses a foreach loop to loop through startingDeck
foreach(Card card in startingDeck)
{
    // Prints to console the number and suit of each card object
    Console.WriteLine($"The {card.Number} of {card.Suit}.");
}

// Prints to console the amount of cards in startingDeck
Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

// Creates a new Card list called myHand
List<Card> myHand = new List<Card>();
// Adds three cards to myHand
myHand.Add(new Card("Jack", "Diamonds"));
myHand.Add(new Card("8", "Hearts"));
myHand.Add(new Card("3", "Diamonds"));

// Prints to console "Got any 8's?"
Console.WriteLine("Got any 8's?");
// Creates an if statement that adds a card to myHand by popping the startingDeck if the number of cards in startingDeck was greater than 0
if(startingDeck.Count > 0)
{
    myHand.Add(startingDeck.Pop());
}

// Prints to console the amount of cards in startingDeck
Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

// Pushes a card from myHand to startingDeck
startingDeck.Push(myHand[0]);
// Removes the card from myHand that was pushed to startingDeck 
myHand.RemoveAt(0);

// Prints to console "Cards in Deck:"
Console.WriteLine("Cards in Deck:");
// Uses a foreach loop to loop through the startingDeck
foreach (Card card in startingDeck)
{
    // Prints to console the number and suit of each card in the startingDeck
    Console.WriteLine($"The {card.Number} of {card.Suit}.");
}