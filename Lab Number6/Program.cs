using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number6
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string response = "";
            Console.WriteLine("Welcome to the Academic Games of Grand Circus!");
            //ask user for dice sides
            Console.WriteLine("Roll the dice? (yes or no?)");
            response = Console.ReadLine().ToLower();


            while (true)
            {

                if (response == "no")
                {
                    return;
                }
                Console.WriteLine("How many sides should each die have?");

                

                //asking the string to hold sides
                string sides = Console.ReadLine();
                //converting sides
                int numberSides = int.Parse(sides);

                int RollNum1 = Rolldice(numberSides);
                int RollNum2 = Rolldice(numberSides);

                DiceRollerApp.CheckRoll(RollNum1, RollNum2);
                Console.WriteLine($"First roll is {RollNum1}, Second roll is {RollNum2}");
                //prompt user for dice roll
                while (true)
                {

                    Console.WriteLine("Do you want to roll the dice again or exit?");
                    response = Console.ReadLine();
                    if (response == "exit")
                    {
                        Console.WriteLine("Thank you for participating! Goodbye");
                        return;
                    }
                    else if (response == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that method isn't valid. Please enter 'y' or exit.");

                    }
                }

            }
            //ask if user wants to continue
            Console.WriteLine("Play again?");
            response = Console.ReadLine();


            while (true)
            {
                if (response == "exit")
                {
                    Console.WriteLine("Thank you for participating! Goodbye");
                    return;
                }
                else if (response == "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that method isn't valid. Please enter 'y' or exit.");
                    response = Console.ReadLine();

                }
            }
        }

        static int Rolldice(int numberSides)
        {
            int num = rnd.Next(1, numberSides + 1);

            return num;


        }


    }
}



