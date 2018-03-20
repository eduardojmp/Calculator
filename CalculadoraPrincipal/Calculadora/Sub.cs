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
        public int sub(List<int> OpreationNumbers)
        {
            int result = OpreationNumbers[0];
            OpreationNumbers.Remove(OpreationNumbers[0]);

            foreach (var numb in OpreationNumbers)
            {
                result = result - numb;
            }

            return result;
        }

        public int doOperation(List<int> OpreationNumbers)
        {
            int result = sub(OpreationNumbers);

            return result;
        }

    }
}
