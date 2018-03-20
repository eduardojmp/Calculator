using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Mult:IMult
    {
        public int mult(List<int> OpreationNumbers)
        {
            int result = 1;

            foreach (var numb in OpreationNumbers)
            {
                result = result * numb;
            }

            return result;
        }

        public int doOperation(List<int> OpreationNumbers)
        {
            int result = mult(OpreationNumbers);

            return result;
        }

    }
}
