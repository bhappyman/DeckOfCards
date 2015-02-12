using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DeckOfCards
{
    [TestFixture]
    class Test
    {
        
        [Test]
        public void ConstructorTest()
        {
            Deck deck = new Deck();
            Assert.IsTrue(deck.DeckOfCards.Distinct().Count() == 52, "Deck does not have 52 unique cards");
        }

        
        [Test]
        public void DealTest()
        {
            Deck deck = new Deck();
            List<Card> hand = deck.Deal(5);
            Assert.IsTrue(deck.DeckOfCards.Count == 47, "DeckOfCards should have 47 cards after dealing 5");
        }

        
        [Test]
        public void DiscardTest()
        {
            Deck deck = new Deck();
            List<Card> hand = deck.Deal(5);
            deck.Discard(hand);
            Assert.IsTrue(deck.DiscardedCards.Count == 5, "Discard pile should have 5 cards after discarding 5 from a hand");
        }

        [Test]
        public void ShuffleTest()
        {
            Deck deck = new Deck();
            Card card = deck.DeckOfCards[10];
            deck.Shuffle();
            Assert.IsTrue(deck.DeckOfCards[10] != card, "Card was still at the same index.");
        }

    }
}
