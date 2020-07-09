using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Lib
{
   public class Deck
   {
      private List<ICard> _cards;

      public List<ICard> Cards
      {
         get
         {
            return _cards;
         }
         set
         {
            _cards = value;
         }
      }

      public Deck()
      {
      }

      public void DealDeck(Game game, int numberOfCardsPerPlayer)
      {
         int deckCounter = _cards.Count() - 1;
         for (int i = 1; i <= numberOfCardsPerPlayer; i++)
         {
            foreach (var player in game.Players)
            {
               player.Cards.Add(_cards[deckCounter]);
               _cards.RemoveAt(deckCounter);
               deckCounter--;
            }
         }
      }

      public void CreateDeck()
      {
         _cards = new List<ICard>();
         List<string> suits = new List<string>() { "Hearts", "Spade", "Diamonds", "Clubs" };

         foreach (var suit in suits)
         {
            for (int i = 1; i < 10; i++)
            {
               var numberCard = new PlayingCard();
               numberCard.Front = $"{suit} : {i.ToString()}";
               numberCard.Back = "Bicycle";
               _cards.Add(numberCard);
            }

            var card = new PlayingCard();
            card.Front = $"{suit} : Jack";
            _cards.Add(card);

            card = new PlayingCard();
            card.Front = $"{suit} : Jack";
            _cards.Add(card);

            card = new PlayingCard();
            card.Front = $"{suit} : Jack";
            _cards.Add(card);

            card = new PlayingCard();
            card.Front = $"{suit} : Jack";
            _cards.Add(card);
         }
      }
   }
}
