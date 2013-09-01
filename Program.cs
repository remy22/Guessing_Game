using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 minInt = 0;
            Int32 maxInt = 0;
            Int32 input = 1;
            Int32 Randoms = 0;
            Int32 trys = 0;

            Random random = new Random();

            Console.Write("What Is the lowest number it can be? ");
            minInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the highest number it can be? ");
            maxInt = Convert.ToInt32(Console.ReadLine());

            Randoms = random.Next(minInt, maxInt);
 
            while (input != 0)
            {
                Console.Write ("Pease guess (0 to stop)");
                input = Convert.ToInt32(Console.ReadLine());
                if (input != 0)
                {
                    trys++;
                    if(input == Randoms)
                    {
                        Console.Write("You won in {0} try's and the number was {1}", trys, Randoms);
                        Randoms = random.Next(minInt, maxInt);
                        Console.ReadKey();
                        trys = 0;
                        Console.Clear();
                    }
                    else
                    {
                        if (input > Randoms)
                        {
                            Console.WriteLine("Please guess lower");
                        }
                        else
                        {
                            Console.WriteLine("Guess higher please");
                        }
                    }

                }
            }

        

        }
    }
}
