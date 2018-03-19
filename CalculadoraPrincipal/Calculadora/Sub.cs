using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Sub:ISub
    {
        Numbers numeros;
        public Sub()
        {
            numeros = new Numbers();
        }
        public void sub()
        {
            var retorno = numeros.GetNumbers();

            int result = retorno[0];
            retorno.Remove(retorno[0]);

            foreach (var numb in retorno)
            {
                result = result - numb;
            }
            Console.WriteLine(result);
            Console.WriteLine("Press enter to conitnue.");
            Console.ReadLine();
        }
    }
}
