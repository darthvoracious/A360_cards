using CardGames.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Lib
{
   public class Game
   {
      List<Player> _players = new List<Player>();

      public void AddPlayer(string name)
      { 
         _players.Add(new Player() {Name = name});
      }

      public List<Player> Players
      {
         get
         {
            return _players;
         }
      }

      public Player GetPlayer(string name)
      { 
         return _players.FirstOrDefault(p => p.Name == name);
      }
   }
}
