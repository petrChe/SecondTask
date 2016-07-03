using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SecondTask.Number;
using static SecondTask.MatrixFactory;

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

            Console.WriteLine("Write the number of rows:");
            int rowCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the number of columns:");
            int columnCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The matrix:");
            Matrix matrix = CreateMatrix(rowCount, columnCount);
            matrix.MatrixToString(matrix);
            Console.WriteLine();
            Console.WriteLine("The inverted matrix:");
            matrix.MatrixToString(matrix.invertMatrix(matrix));
            
            Console.WriteLine("Write the number of rows:");
            int firstRowCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the number of columns:");
            int firstColumnCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first matrix:");
            Matrix firstMatrix = CreateMatrix(firstRowCount, firstColumnCount);
            firstMatrix.MatrixToString(firstMatrix);
            Console.WriteLine("Write the number of rows:");
            int secondRowCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the number of columns:");
            int secondColumnCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second matrix:");
            Matrix secondMatrix = CreateMatrix(secondRowCount, secondColumnCount);
            secondMatrix.MatrixToString(secondMatrix);

            MatrixOperator firstMatrixOperator = new MatrixOperator();
            Matrix addResultMatrix = firstMatrixOperator.MatrixAddition(firstMatrix, secondMatrix);
            Console.WriteLine("The result of add matrix:");
            addResultMatrix.MatrixToString(addResultMatrix);

            MatrixOperator secondMatrixOperator = new MatrixOperator();
            Matrix subResultMatrix = secondMatrixOperator.MatrixSubtraction(firstMatrix, secondMatrix);
            Console.WriteLine("The result of sub matrix:");
            subResultMatrix.MatrixToString(subResultMatrix);

            MatrixOperator thirdMatrixOperator = new MatrixOperator();
            Matrix multiplyResultMatrix = thirdMatrixOperator.MatrixMultiply(firstMatrix, secondMatrix);
            Console.WriteLine("The result of multiply matrix:");
            multiplyResultMatrix.MatrixToString(multiplyResultMatrix);
            
            Console.ReadKey();
        }
    }
}
