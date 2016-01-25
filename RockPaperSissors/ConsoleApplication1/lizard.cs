using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class lizard : winnerorloser
    {
         
        public bool displayWin()
        {
            Console.WriteLine("Lizard beats sissor");
            Console.WriteLine("Lizard beats lizard");
            return displayWin();
        }
        public bool displayLoss()
        {
            Console.WriteLine("Lizard loses to paper");
            Console.WriteLine("Lizard loses to spock");
            return displayLoss();
        }

    }
}

