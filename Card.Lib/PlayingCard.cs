using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Lib
{
   public class PlayingCard : ICard
   {
      public string Front { get;  set ; }
      public string Back { get; set ; }
   }
}
