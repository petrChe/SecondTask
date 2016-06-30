using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SecondTask.Number;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ACCURACY = 0.0001;// result depends on the accuracy
            Console.Clear();
            Console.WriteLine("White the n: ");
            double n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("White the num: ");
            double num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Newton method result " + NewtoneMethod(num, n, ACCURACY));
            double powMethodResult = Math.Pow(num, 1 / n);
            Console.WriteLine("Pow Method result " + powMethodResult);
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary: " + DecimalToBinary(number));
            Console.ReadKey();
        }
    }
}
