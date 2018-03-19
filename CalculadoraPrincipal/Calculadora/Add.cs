using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Add:IAdd
    {
        Numbers numeros;
        public Add()
        {
            numeros = new Numbers();
        }
        public void add()
        {
            var retorno = numeros.GetNumbers();

            int result = 0;

            foreach(var numb in retorno)
            {
                result += numb;
            }
            Console.WriteLine(result);
            Console.WriteLine("Press enter to conitnue.");
            Console.ReadLine();
        }
    }
}
