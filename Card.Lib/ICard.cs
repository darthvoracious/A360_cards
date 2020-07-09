using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Lib
{
   public interface ICard
   {
      string Front {get; set;} 

      string Back {get; set;}
   }
}
