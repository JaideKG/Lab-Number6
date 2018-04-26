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
            while (true)
            {
                Console.WriteLine("Welcome to the Academic Games of Grand Circus!");
                //ask user for dice sides
                Console.WriteLine("How many sides are there?");
                //asking the string to hold sides
                string sides = Console.ReadLine();
                //converting sides
                int numberSides = int.Parse(sides);
                Console.WriteLine("Do you want to roll the dice or exit?");
                string response = Console.ReadLine();

                //prompt user for dice roll
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
                int rolledNum = Rolldice(numberSides);
                int rolledNum2 = Rolldice(numberSides);



                Console.WriteLine($"1st number {rolledNum} 2nd number {rolledNum2}");
                //display what they have rolled

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
        }

        static int Rolldice(int numberSides)
        {
            int num = rnd.Next(1,numberSides);

            return num;
            

        }


    }

    

}
