using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ComputerGamePlay
    {
        Random random = new Random();
        public static string result;
        public string getCompChoice()
        {
            int choice = random.Next(0, 5);
            string result = "";

            if (choice == 0)
            {
                result = "rock";
            }
            else if (choice == 1)
            {
                result = "paper";
            }
            else if (choice == 2)
            {
                result = "scissors";
            }
            else if (choice == 3)
            {
                result = "lizard";
            }
            else if (choice == 4)
            {
                result = "Spock";
            }
            return result;

        }
    }
}
