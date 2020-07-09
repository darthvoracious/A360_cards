using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Lib
{
   public static class DeckExtensions
   {
      private static Random rng = new Random(); 
      public static void Shuffle<T>(this IList<T> cards)
      {
         int n = cards.Count;
         while (n > 1)
         {
            n--;
            int k = rng.Next(n + 1);
            T value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
         }
      }

   }
}
