using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Div:IDiv
    {
        public void div(List<int> retorno)
        {

            int result = retorno[0];
            retorno.Remove(retorno[0]);


            try
            {
                foreach (var numb in retorno)
                {
                    result = result / numb;
                }

                Console.WriteLine(result);
                Console.WriteLine("Press enter to conitnue.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                Console.ReadLine();
            }
        }
    }
}
