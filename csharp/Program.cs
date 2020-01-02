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
        {
            Random rand = new Random();

            Console.Write("What is your name?");
            string s = Console.ReadLine();
            string[] s1 = { "Hello, ", "Hi, ", "How do you do, " };
            string[] s2 = { ", nice to meet you", ", i'm glad to meet you", ", i've heard a lot about you", ", i'm honored to meet you", "" };
            string[] s3 = { "!", "." };

            Console.WriteLine(string.Format("{0}{1}{2}{3}", s1[rand.Next(0, s1.Length)], s, s2[rand.Next(0, s2.Length)], s3[rand.Next(0, s3.Length)]));

            Console.WriteLine("");
            Main();


        }
    }
}
