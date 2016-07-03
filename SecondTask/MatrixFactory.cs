using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class MatrixFactory
    {
        
        public static Matrix CreateMatrix(int rowCount, int columnCount)
        {
            
            Matrix matrix = new Matrix(rowCount, columnCount);
            int[,] matrixArray = matrix.GetMatrixArray();
            Random rand = new Random();
            for(int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < columnCount; j++)
                {
                    matrixArray[i, j] = rand.Next(0, 10);
                }
            }
            matrix.SetMatrixArray(matrixArray);
            return matrix;
        }

     



    }
}
