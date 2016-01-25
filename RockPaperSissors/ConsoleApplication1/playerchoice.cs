using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Playerchoice : userInput
    {
       public int PlayersMove()
        {
            string userSign = null;
            bool Checksign = false;
            int signValue = 0;

            while (Checksign == false)
            {
                userSign = getUserInput("Rock, Paper, Sissors, lizard, or spock? \n");
                switch (userSign)
                {
                    case "rock":
                        Checksign = true;
                        signValue = 0;
                        break;
                    case "paper":
                        Checksign = true;
                        signValue = 1;
                        break;
                    case "scissors":
                        Checksign = true;
                        signValue = 2;
                        break;
                    case "spock":
                        Checksign = true;
                        signValue = 3;
                        break;
                    case "lizard":
                        Checksign = true;
                        signValue = 4;
                        break;
                    default:
                        Console.WriteLine("Not valid");
                        break;
                }
            }
            return signValue;
        }

    }
       
}
