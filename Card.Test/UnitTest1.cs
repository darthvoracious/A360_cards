using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGames.Lib;

namespace Card.Test
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void DeckShouldConatainFifyTwoCards()
      {
         // Arrange
         Deck deck = new Deck();

         // Act
         deck.CreateDeck();

         // Assert
         Assert.IsTrue(deck.Cards.Count == 52);
      }

      [TestMethod]
      public void DeckShouldHaveFourtyTwoCardsLeftInATwoPlayerGameWithAFiveCardHand()
      {
         //Arrange
         Deck deck = new Deck();
         deck.CreateDeck();
         deck.Cards.Shuffle();
         Game game = new Game();

         game.AddPlayer("Chris");
         game.AddPlayer("Brian");

         //Act
         deck.DealDeck(game, 5);

         //Assert
         Assert.IsTrue(deck.Cards.Count == 42);

      }
   }
}
