using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Lib
{
   public class Player
   {
      List<ICard> _cards = new List<ICard>();

      public string Name {get; set;}

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
   }
}
