using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class spock : winnerorloser
    {
         
        public bool displayWin()
        {
            Console.WriteLine("Spock beats rock");
            Console.WriteLine("Spock beats scissors");
            return displayWin();
        }
        public bool displayLoss()
        {
            Console.WriteLine("Spock loses to paper");
            Console.WriteLine("Spock loses to lizard");
            return displayLoss();
        }

    }
}
