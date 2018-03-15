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
        public void add()
        {
            Numbers numeros = new Numbers();
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
