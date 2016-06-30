using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double x = 1;

            for (;;)
            {

                double nx = x;
                x = nx + (num / Math.Pow(nx, n - 1) - nx) / num;
                if (Math.Abs(x - nx) < ACCURACY) break;

            }
            Console.WriteLine("Newton method result " + x);
            double powMethodResult = Math.Pow(num, 1 / n);
            Console.WriteLine("Pow Method result " + powMethodResult);

            Console.WriteLine("White the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            string s = "";
            while (number != 0)
            {
                result = number % 2;
                s = result + s;
                number /= 2;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
