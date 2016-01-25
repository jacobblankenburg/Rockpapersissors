using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class playersname
    {
        public string UserNamePlayer1()
        {
             string name;

            Console.WriteLine("Please enter your name:  ");

            name = Console.ReadLine();

            Console.WriteLine("Player 1 - {0}. \n", name);
            return name;

        }
        public string userNamePlayer2()
        {
            string name2;

            Console.WriteLine("Please enter player 2s name:  ");

            name2 = Console.ReadLine();
    
            Console.WriteLine("Player 2 - {0}. \n", name2);
            return name2;
        }

        public string computerName()
        {
            string computerName;
            computerName = "Computer";
            return computerName;
        }
    }
}
