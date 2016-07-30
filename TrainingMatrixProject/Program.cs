using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMatrixProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            int[] firstMatrixArray = new int[rows];
            int[,] secondMatrixArray = new int[rows, columns];
            bool flag;
            for (int i = 0; i < rows; i++)
            {
                firstMatrixArray[i] = random.Next(-10, 10);
                for (int j = 0; j < columns; j++)
                {
                    secondMatrixArray[i, j] = random.Next(-10, 10);
                }
            }
            string str2 = "";
            for (int i = 0; i < rows; i++)
            {
                string str = "";
                str2 += " " + firstMatrixArray[i].ToString() + " ";
                for (int j = 0; j < columns; j++)
                {
                    str += secondMatrixArray[i, j].ToString() + " ";
                }


                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine(str2);
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                if (firstMatrixArray[i] < 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                string str3 = "";
                for (int j = 0; j < columns; j++)
                {
                    if (flag == true)
                    {
                        if (secondMatrixArray[i, j] < 0)
                        {
                            secondMatrixArray[i, j] = -1;
                        }
                        else if (secondMatrixArray[i, j] > 0)
                        {
                            secondMatrixArray[i, j] = 1;
                        }
                    }
                    str3 += secondMatrixArray[i, j].ToString() + " ";
                }
                Console.WriteLine(str3);
            }
            Console.ReadKey();
        }
    }
}
