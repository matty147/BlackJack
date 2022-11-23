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

            int YMoney = 100; //Player money
            int Bet = 0; //Players bet
            int Hand1 = 0; // Player's hand
            int Hand2 = 0; //Dealer's hand
            int Card = 0; //The card that is being chosen
            int Options = 0; //Option loop on/off
            Random rnd = new Random();
            int Exit = 0;
            while (Exit == 0)
            {
                Hand1 = 0;
                Hand2 = 0;
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
                Options = 1;
                while (Options == 1)
                {
                    Console.WriteLine("Your money: " + (YMoney) + ("$"));
                    Console.WriteLine("Place your bet");
                    Bet = int.Parse(Console.ReadLine()); //Entering a leter chrashes the program + int overflow


                    if (Bet < 0 || Bet > YMoney)
                    {
                        Console.WriteLine("Invalid bet");
                        Console.WriteLine("Please bet again");
                    }
                    else
                    {
                        Options = 0;
                    }
                    Console.WriteLine("");
                }
                while (Options == 0)
                {
                    Console.WriteLine("Your options: ");
                    Console.WriteLine("Hit, Stand");

                    string Option = Console.ReadLine();
                    if (Option == "Hit" || Option == "hit" || Option == "HIT" || Option == "H" || Option == "h")
                    {
                        Console.WriteLine("Your extra card: ");
                        Card = rnd.Next(1, 11);
                        Console.WriteLine(Card);
                        Hand1 += Card;
                        Options = 0;
                        Console.WriteLine("Your total: " + (Hand1));
                        Console.WriteLine(" ");
                        if (Hand1 >= 21)
                        {
                            Options = 1;
                        }
                    }
                    else
                    if (Option == "Stand" || Option == "stand" || Option == "STAND" || Option == "s" || Option == "S")
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
                Console.WriteLine("Dealer's hand: " + (Hand2));
                if (Hand1 > 21)
                {
                    Console.WriteLine("You lost");
                    YMoney -= Bet;
                    Console.WriteLine("-" + (Bet) + ("$"));
                }
                else
                if (Hand2 > 21)
                {
                    Console.WriteLine("You won");
                    YMoney += Bet;
                    Console.WriteLine("+" + (Bet) + ("$"));
                }
                else
                if (Hand1 == Hand2)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine("+0$");
                }
                else if (Hand1 < Hand2)
                {
                    Console.WriteLine("You lost");
                    YMoney -= Bet;
                    Console.WriteLine("-" + (Bet) + ("$"));
                }
                else if (Hand1 > Hand2)
                {
                    Console.WriteLine("You won");
                    YMoney += Bet;
                    Console.WriteLine("+" + (Bet) + ("$"));
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.WriteLine("");

                while (Options == 1)
                {
                    Console.WriteLine("Play again?");
                    Console.WriteLine("Yes/No");
                    string Option2 = Console.ReadLine();
                    if (Option2 == "Yes" || Option2 == "Y" || Option2 == "y")
                    {
                        Options = 0;
                        if (YMoney <= 0)
                        {
                            Exit = 1;
                            Console.WriteLine("You don't have any money");
                            Console.ReadKey();
                        }
                    }
                    else
                    if (Option2 == "No" || Option2 == "N" || Option2 == "n")
                    {
                        Exit = 1;
                        Options = 0;
                    }
                    else
                    {
                        Options = 1;
                        Console.WriteLine("Invalid command");
                        Console.WriteLine("Try again");
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("-----------------------");
                Console.WriteLine("");
            }
        }
    }
}

