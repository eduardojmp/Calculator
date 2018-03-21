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
        public int add(List<int> OpreationNumbers)
        {
            int result = 0;

            foreach(var numb in OpreationNumbers)
            {
                result += numb;
            }

            return result;
        }

        public int doOperation(List<int> OpreationNumbers)
        {
            return add(OpreationNumbers);
        }
    }
}
