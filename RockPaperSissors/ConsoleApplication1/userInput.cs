using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class userInput
    {
        public string getUserInput(string Message)
        {
            Console.WriteLine(Message);
            string userinput = Console.ReadLine();
            return userinput;
        }
    }
}