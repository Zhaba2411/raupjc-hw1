using System;

namespace Task2
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

            Console.WriteLine(listOfDoubles.Contains(1.23));

            listOfDoubles.RemoveAt(0); // [2 ,3 ,4 ,5]
            Console.WriteLine(listOfDoubles.GetElement(0));
            Console.WriteLine(listOfDoubles.GetElement(3));
            listOfDoubles.Remove(5); //[2 ,3 ,4]

            Console.WriteLine(listOfDoubles.Count); // 3
            Console.WriteLine(listOfDoubles.Remove(100.233)); // false
            Console.WriteLine(listOfDoubles.RemoveAt(5)); // false
            listOfDoubles.Clear(); // []
            Console.WriteLine(listOfDoubles.Count); // 0

            

            listOfDoubles.Add(1);
            Console.Write(listOfDoubles.GetElement(0));

            Console.ReadLine();
        }
    }
}
