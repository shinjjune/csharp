using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program2
    {
        static void Main2(string[] args)
        {
            while(true)
            {
                string inputString;

                Console.Write("what is the input string?");
                inputString = Console.ReadLine();
                if(inputString == "")
                {
                    Console.WriteLine("Input any key");
                }
                else
                {
                    Console.WriteLine("{0} has {1} characters", inputString, inputString.Length);
                }
            }

        }
    }
}
