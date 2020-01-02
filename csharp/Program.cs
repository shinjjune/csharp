using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static int Calc(int first, int second, string alth)
        {
            switch (alth)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                default:
                    return first / second;
            }
        }
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
            // Calculator
            {
                // while(true)
                {
                    int iFirst = 0, iSecond = 0;

                    First:
                    Console.Write("What is the First Number? ");
                    string firstNum = Console.ReadLine();

                    if(!int.TryParse(firstNum, out iFirst))
                    {
                        goto First;
                    }
                    if(iFirst <0)
                    {
                        goto First;
                    }
                Second:
                    Console.Write("What is the Second Number? ");
                    string secondNum = Console.ReadLine();

                    if(!int.TryParse(secondNum, out iSecond))
                    {
                        goto Second;
                    }
                    if(iSecond<0)
                    {
                        goto Second;
                    }
                    Console.WriteLine("{0}+{1}={2}", iFirst, iSecond, Calc(iFirst, iSecond, "+"));
                    Console.WriteLine("{0}-{1}={2}", iFirst, iSecond, Calc(iFirst, iSecond, "-"));
                    Console.WriteLine("{0}*{1}={2}", iFirst, iSecond, Calc(iFirst, iSecond, "*"));
                    Console.WriteLine("{0}/{1}={2}", iFirst, iSecond, Calc(iFirst, iSecond, "/"));
                }
            }
            // retirement
            {
                Console.Write("What is your current age? ");
                int nage = int.Parse(Console.ReadLine());

                Console.Write("At What age would you like to retire? ");
                int rage = int.Parse(Console.ReadLine()) - nage;

                int nyear = DateTime.Now.Year; //  올해연도
                int ryear = nyear + rage;

                if (rage > 0)
                {
                    Console.WriteLine("You have {0} years left until you can retire.", rage);
                    Console.WriteLine("It's {0}, so you can retire in {1}.", nyear, ryear);
                }
                else
                {    // 음수가 나오면 퇴직되었다고 출력
                    Console.WriteLine("You have been retired for {0} years.", rage.ToString().Replace("-", ""));
                    Console.WriteLine("It's {0}, You already retired. Thank you!", nyear);

                }
            }
        }
        
    }
}
