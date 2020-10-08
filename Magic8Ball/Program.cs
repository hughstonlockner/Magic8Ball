using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                String questionString = GetQuestionFromUser();
                int randomNumber = randomObject.Next(4);
                switch(randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Bad Idea!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("That's a mystery for the ages!");
                            break;
                        }

                }
            }
        }

    }
}
