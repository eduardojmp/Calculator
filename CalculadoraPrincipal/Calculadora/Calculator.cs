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
        private IList<IOperation> _operations;
        private IMenu _menu;
        Numbers numeros;

        public Calculator(IList<IOperation> operations, IMenu menu)
        {
            _operations = operations;
            _menu = menu;
            numeros = new Numbers();
        }

        public Calculator()
            : this(new List<IOperation>() { new Add(), new Sub(), new Mult(), new Div(), }, new CalculatorMenu())
        { }

        public void Start()
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                _menu.InitializeMainMenu();

                var operation = _menu.GetOperationFromMenu();

                displayMenu = ProcessOperation(operation);
            }
        }

        private bool ProcessOperation(int OperationType)
        {

            if (OperationType <= _operations.Count)
            {
                List<int> OpreationNumbers = numeros.GetNumbers();

                int final_result = _operations.ElementAt(OperationType - 1).doOperation(OpreationNumbers);

                Console.WriteLine(final_result);
                Console.WriteLine("Press enter to conitnue.");
                Console.ReadLine();
            }
            else if (OperationType == _operations.Count + 1)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid! Try again!");
                Console.ReadLine();
            }

            return true;
        }
    }
}
