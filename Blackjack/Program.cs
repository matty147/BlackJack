using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Hand1 = 0;
            int Hand2 = 0;
            int Card = 0;
            int Options = 0;
            Random rnd = new Random();

            Console.WriteLine("Dealer's cards: ");
            for (int i = 0; i < 1; i++)
            {
                Card = rnd.Next(1, 11);
                Console.WriteLine(Card);
                Hand2 += Card;
            }
            Console.Write("Total: ");
            Console.WriteLine(Hand2);
            Console.WriteLine(" ");
            Console.WriteLine("Your cards:");
            for (int i = 0; i < 2; i++)
            {
                Card = rnd.Next(1, 11);
                Console.WriteLine(Card);
                Hand1 += Card;

            }
            Console.Write("Total: ");
            Console.WriteLine(Hand1);
            Console.WriteLine(" ");
            while (Options == 0)
            {
                Console.WriteLine("Your options: ");
                Console.WriteLine("Hit, Stand");

                string Option = Console.ReadLine();
                if (Option == "Hit")
                {
                    Console.WriteLine("Your extra card: ");
                    Card = rnd.Next(1, 11);
                    Console.WriteLine(Card);
                    Hand1 += Card;
                    Options = 0;
                    Console.WriteLine("Your total: " + (Hand1));
                    Console.WriteLine(" ");
                    if (Hand1 > 21)
                    {
                        Options = 1;
                    }
                }
                else
                if (Option == "Stand")
                {
                    Options = 1;
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Not a valid command");
                    Console.WriteLine("Try again");
                    Console.WriteLine(" ");
                }
            }

            while (Hand2 < 17)
            {
                Card = rnd.Next(1, 11);
                Console.WriteLine(Card);
                Hand2 += Card;
            }


            Console.WriteLine("Final hand totals: ");
            Console.WriteLine("Your hand: " + (Hand1));
            Console.WriteLine("Deaker's hand: " + (Hand2));
            if (Hand1 > 21)
            {
                Console.WriteLine("You lost");
            }
            else
            if (Hand2 > 21)
            {
                Console.WriteLine("You won");
            }
            else
            if (Hand1 == Hand2)
            {
                Console.WriteLine("Draw");
            }
            else if (Hand1 < Hand2)
            {
                Console.WriteLine("You lost");
            }
            else if (Hand1 > Hand2)
            {
                Console.WriteLine("You won");
            } else
            {
                Console.WriteLine("Error");
            }


            Console.ReadKey();
        }
    }
}
