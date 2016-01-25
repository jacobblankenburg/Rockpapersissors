using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class paper : winnerorloser
    {
         
        public bool displayWin()
        {
            Console.WriteLine("Paper beats rock");
            Console.WriteLine("Paper beats spock");
            return displayWin();
        }
        public bool displayLoss()
        {
            Console.WriteLine("Paper loses to scissor");
            Console.WriteLine("Paper loses to lizard");
            return displayLoss();
        }

    }
}

