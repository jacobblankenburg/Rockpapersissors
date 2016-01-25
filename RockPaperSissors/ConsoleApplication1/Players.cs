using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Players : userInput
    {
        public int howManyplayers;
        public int getPlayers()
        {
            howManyplayers = Convert.ToInt32(getUserInput("1 or 2 player?"));
            return howManyplayers;
        }
    }
}
