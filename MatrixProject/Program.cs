using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MatrixProject.MatrixFactory;

namespace MatrixProject
{
    class Program
    {
        static void Main(string[] args)
        {
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
            try
            {
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

                //MatrixOperator secondMatrixOperator = new MatrixOperator();
                //Matrix subResultMatrix = secondMatrixOperator.MatrixSubtraction(firstMatrix, secondMatrix);
                //Console.WriteLine("The result of sub matrix:");
                //subResultMatrix.MatrixToString(subResultMatrix);

                //MatrixOperator thirdMatrixOperator = new MatrixOperator();
                //Matrix multiplyResultMatrix = thirdMatrixOperator.MatrixMultiply(firstMatrix, secondMatrix);
                //Console.WriteLine("The result of multiply matrix:");
                //multiplyResultMatrix.MatrixToString(multiplyResultMatrix);
                //Console.ReadKey();
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
            }
        }
    }
}
