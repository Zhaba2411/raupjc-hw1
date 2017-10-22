using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<Double> listOfDoubles = new GenericList<Double>();

            listOfDoubles.Add(1.23);
            listOfDoubles.Add(2.23);
            listOfDoubles.Add(3.23);
            listOfDoubles.Add(4.23);
            listOfDoubles.Add(5.23);

            foreach(Double i in listOfDoubles)
            {

                if (i > 2)
                {
                    Console.WriteLine(i);
                }
                
            }

            Console.ReadLine();
        }
    }
}
