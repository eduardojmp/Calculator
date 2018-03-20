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
        public int div(List<int> OpreationNumbers)
        {

            int result = OpreationNumbers[0];
            OpreationNumbers.Remove(OpreationNumbers[0]);

            try
            {
                foreach (var numb in OpreationNumbers)
                {
                    result = result / numb;
                }

            }
            catch (Exception ex)
            {
                result = 0;

                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                Console.ReadLine();
            }

            return result;
        }

        public int doOperation(List<int> OpreationNumbers)
        {
            int result = div(OpreationNumbers);

            return result;
        }

    }
}
