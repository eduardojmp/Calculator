using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculator:ICalculator
    {
        Add AddOperation;
        Sub SubOperation;
        Mult MultOperation;
        Div DivOperation;

        public Calculator()
        {
            AddOperation = new Add();
            SubOperation = new Sub();
            MultOperation = new Mult();
            DivOperation = new Div();
        }
        public void Start()
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = InitializeMainMenu();
            }
        }

        private bool InitializeMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) Exit");

            string OperationType = Console.ReadLine();

            return ProcessOperation(OperationType);
        }

        private bool ProcessOperation(string OperationType)
        {
            if (OperationType == "1")
            {
                AddOperation.add();

                return true;
            }
            else if (OperationType == "2")
            {
                SubOperation.sub();

                return true;
            }
            else if (OperationType == "3")
            {
                MultOperation.mult();

                return true;
            }
            else if (OperationType == "4")
            {
                DivOperation.div();

                return true;
            }
            else if (OperationType == "5")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid! Try again!");
                Console.ReadLine();
                return true;
            }
        }
    }
}
