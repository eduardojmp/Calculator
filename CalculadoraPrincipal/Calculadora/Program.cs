using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) Exit");

            string n = Console.ReadLine();

            if (n == "1")
            {
                Console.WriteLine("First number of equation: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Second number of equation: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                int result = n1 + n2;
                Console.WriteLine(result);
                Console.WriteLine("Press enter to conitnue.");
                Console.ReadLine();
                return true;
            }
            else if (n == "2")
            {
                Console.WriteLine("First number of equation: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Second number of equation: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                int result = n1 - n2;
                Console.WriteLine(result);
                Console.WriteLine("Press enter to conitnue.");
                Console.ReadLine();
                return true;
            }
            else if (n == "3")
            {
                Console.WriteLine("First number of equation: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Second number of equation: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                int result = n1 * n2;
                Console.WriteLine(result);
                Console.WriteLine("Press enter to conitnue.");
                Console.ReadLine();
                return true;
            }
            else if (n == "4")
            {
                Console.WriteLine("First number of equation: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Second number of equation: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                try
                {
                    int result = n1 / n2;
                    Console.WriteLine(result);
                    Console.WriteLine("Press enter to conitnue.");
                    Console.ReadLine();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                    Console.ReadLine();
                }
                return true;
            }
            else if (n == "5")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalide! Try again!");
                Console.ReadLine();
                return true;
            }
        }
    }
}
