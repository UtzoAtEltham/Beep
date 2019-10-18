using System;

namespace Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Random random;
            Random opt = new Random();
            Console.WriteLine("F0rGiVe Me M0rTaL!");
        BEEP:
            int dice = opt.Next(1, 10);          
            if (dice == 1)
            {
                Console.Beep(2000,300);
            }
            if (dice == 2)
            {
                Console.Beep();
            }
            if (dice == 3)
            {
                Console.Beep(6000,100);
            }
            if (dice == 4)
            {
                Console.Beep(10000, 500);
            }
                if (dice == 5)
                {
                    Console.Beep(6000, 500);
                }
                if (dice == 6)
                {
                    Console.Beep(1000, 300);
                }
                if (dice == 7)
                {
                    Console.Beep(15000, 800);
                }
                if (dice == 8)
                {
                    Console.Beep(20000, 500);
                }
                if (dice == 9)
                {
                    Console.Beep(3700, 100);
                }
                if (dice == 10)
                {
                Console.Beep(14600, 100);

                }
            goto BEEP;
        }
           
        }
    }      