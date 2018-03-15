using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Numbers
    {
        public List<int> GetNumbers()
        {
            var num = new List<int>();
            
            Console.WriteLine("1º number of equation: ");
            num.Add(Convert.ToInt32(Console.ReadLine()));

            int i = 2;

            do
            {
                Console.WriteLine("{0}º number of equation: ", i);
                num.Add(Convert.ToInt32(Console.ReadLine()));
                i++;

                Console.WriteLine("Press 'r' for result or any other key for more numbers");
                string cont = Console.ReadLine();
                if (cont == "r")
                {
                    break;
                }

            } while (true);

            return num;
        }
    }
}
