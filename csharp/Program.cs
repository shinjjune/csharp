using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main()
            // Hello
        {
            Random rand = new Random();

            Console.Write("What is your name?");
            string s = Console.ReadLine();
            string[] s1 = { "Hello, ", "Hi, ", "How do you do, " };
            string[] s2 = { ", nice to meet you", ", i'm glad to meet you", ", i've heard a lot about you", ", i'm honored to meet you", "" };
            string[] s3 = { "!", "." };

            Console.WriteLine(string.Format("{0}{1}{2}{3}", s1[rand.Next(0, s1.Length)], s, s2[rand.Next(0, s2.Length)], s3[rand.Next(0, s3.Length)]));

            Console.WriteLine("");
            // Count
            // while (true)
            {
                string inputString;

                Console.Write("what is the input string?");
                inputString = Console.ReadLine();
                if (inputString == "")
                {
                    Console.WriteLine("Input any key");
                }
                else
                {
                    Console.WriteLine("{0} has {1} characters", inputString, inputString.Length);
                }
            }
            // Double Quotation
            {
                string inputQuote, inputName;
                Console.Write("what is the quote?");
                inputQuote = Console.ReadLine();
                Console.Write("who said it? ");
                inputName = Console.ReadLine();
                Console.WriteLine(inputName + " says, \"" + inputQuote + "\"");
                Console.ReadLine();
            }
            // Mad Libs
            {
                // while(true)
                {
                    string snoun, sverb, sadjective, sadverb, sinterjection;
                    Console.Write("Enter a noun :");
                    snoun = Console.ReadLine();
                    Console.Write("Enter a verb :");
                    sverb = Console.ReadLine();
                    Console.Write("Enter a adjective :");
                    sadjective = Console.ReadLine();
                    Console.Write("Enter a adverb :");
                    sadverb = Console.ReadLine();
                    Console.Write("Enter a interjection :");
                    sinterjection = Console.ReadLine();

                    Console.WriteLine("Do you {1} your {2} {0} {3}? That's {4}!", snoun, sverb, sadjective, sadverb, sinterjection);
                }
            }

        }
    }
   
}
