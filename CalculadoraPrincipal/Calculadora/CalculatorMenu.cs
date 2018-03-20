using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculatorMenu:IMenu
    {
        public void InitializeMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) Exit");
        }

        public int GetOperationFromMenu()
        {
            int operation = Convert.ToInt32(Console.ReadLine());

            return operation;
        }
    }
}
