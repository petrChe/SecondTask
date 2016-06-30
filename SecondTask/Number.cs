using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public static class Number
    {
        public static double NewtoneMethod(double number, double n, double accurancy)
        {
            double x0 = 1;
            for (;;)
            {

                double nx = x0;
                x0 = nx + (number / Math.Pow(nx, n - 1) - nx) / number;
                if (Math.Abs(x0 - nx) < accurancy) break;

            }
            return x0;
        }

        public static string DecimalToBinary(int number)
        {
            int result;
            string resultString = "";
            while (number > 0) {
                result = number % 2;
                resultString = result + resultString;
                number /= 2;
            }
            
            return resultString;
        }
    }
}
