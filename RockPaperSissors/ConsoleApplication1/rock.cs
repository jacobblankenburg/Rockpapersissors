using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class rock : winnerorloser
    {
        public bool displayWin()
        {
            Console.WriteLine("Rock beats scissor");
            Console.WriteLine("Rock beats lizard");
            return displayWin();
        }
        public bool displayLoss()
        {
            Console.WriteLine("rock loses to paper");
            Console.WriteLine("Rock loses to spock");
            return displayLoss();
        }
        
    }
}
