using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class computerchoice
    {
        public computerchoice()
        {
            Random r = new Random();
            int computerChoice = r.Next(4);
        }
    }
}
