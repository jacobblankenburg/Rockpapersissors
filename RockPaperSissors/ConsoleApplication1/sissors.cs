﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class scissors : winnerorloser
    {
         
        public bool displayWin()
        {
            Console.WriteLine("Scissors beats paper");
            Console.WriteLine("Scissors beats lizard");
            return displayWin();
        }
        public bool displayLoss()
        {
            Console.WriteLine("Scissors loses to rock");
            Console.WriteLine("Scissors loses to spock");
            return displayLoss();
        }

    }
}
