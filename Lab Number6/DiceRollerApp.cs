using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number6
{
    class DiceRollerApp
    {
        public static void CheckRoll(int x, int y)
        {
            if (x + y == 7)
            {
                Console.WriteLine("craps");
                Console.ReadLine();
            }
            else if (x + y == 2)
            {
                Console.WriteLine("snake eyes");
                Console.ReadLine();
            }
            else if (x + y == 12)
            {
                Console.WriteLine("box cars");
                Console.ReadLine();


            


            }

        }
    }
}
