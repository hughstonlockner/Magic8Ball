using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {

        static Random randomObject = new Random();
        static void Main(string[] args)
        {
            Questionloop();
        }
        static string GetQuestionFromUser()
        {
            Console.WriteLine("What question do you have");
            string questionstring = Console.ReadLine();
            return questionstring;
        }
        static void Questionloop()
        {
            while(true)
            {
                int numberOfSecondsToSleep = randomObject.Next((5) + 1);
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                String questionString = GetQuestionFromUser();
                Console.WriteLine("Hmmm... Let me think...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);
                int randomNumber = randomObject.Next(10);
                switch(randomNumber)


                {
                    case 0:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Bad Idea!");
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("That's a mystery for the ages!");
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("I would make doubts instead!");
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("your teacher is a ninja be nice!");
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("42, is the answer to everything!");
                            break;
                        }
                    case 7:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("stop asking questions and make me a pizza!");
                            break;
                        }
                    case 8:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("maybe!");
                            break;
                        }
                    case 9:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("this isnt Canada, speak english!");
                            break;
                        }

                }
                if(questionString.ToLower() == "quit")
                {
                    break;
                }

                if(questionString.ToLower() == "ninja")
                {
                    Console.WriteLine("Shhh... we dont speak of the invisible");
                    break;
                }
            }

        }

    }
}
