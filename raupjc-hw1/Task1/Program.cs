using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList listOfIntegers = new IntegerList();

            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]

            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            Console.Write(listOfIntegers.GetElement(0));
            Console.Write(listOfIntegers.GetElement(1));
            Console.Write(listOfIntegers.GetElement(2));
            Console.Write(listOfIntegers.GetElement(3));
            listOfIntegers.Remove(5); //[2 ,3 ,4]
            Console.WriteLine();
            Console.Write(listOfIntegers.GetElement(0));
            Console.Write(listOfIntegers.GetElement(1));
            Console.Write(listOfIntegers.GetElement(2));

            Console.WriteLine();

            Console.WriteLine(listOfIntegers.Count ); // 3
            Console.WriteLine(listOfIntegers.Remove (100) ); // false
            Console.WriteLine(listOfIntegers.RemoveAt (5)); // false
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count ); // 0

            Console.WriteLine(listOfIntegers.IndexOf(10));
            Console.WriteLine(listOfIntegers.IndexOf(10));

            listOfIntegers.Add(1);
            Console.Write(listOfIntegers.GetElement(0));

            Console.ReadLine();
        }
    }
}
