using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Sissors \n");
            //gamesetup ChoosePlayers = new gamesetup();
            //ChoosePlayers.decideAmountofPlayers();
            
            playersname user = new playersname();
            user.UserNamePlayer1();
            user.userNamePlayer2();
           
            Playerchoice player = new Playerchoice();
            player.PlayersMove();
            
        }
    }
}
