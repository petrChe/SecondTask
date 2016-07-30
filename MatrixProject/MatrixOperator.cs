using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProject
{
    class MatrixOperator : Operator
    {
        public override Matrix MatrixAddition(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix resultMatrix = new Matrix(firstMatrix.GetRowCount(), secondMatrix.GetColumnCount());
            int[,] resultArray = new int[resultMatrix.GetRowCount(), resultMatrix.GetColumnCount()];

            for(int i = 0; i < resultMatrix.GetRowCount(); i++)
            {
                for(int j = 0; j < resultMatrix.GetColumnCount(); j++)
                {   
                    
                    resultArray[i, j] = firstMatrix.GetMatrixArray()[i,j] + secondMatrix.GetMatrixArray()[i, j];
                }
            }
            resultMatrix.SetMatrixArray(resultArray);


            return resultMatrix;
        }

        public override Matrix MatrixSubtraction(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix resultMatrix = new Matrix(firstMatrix.GetRowCount(), secondMatrix.GetColumnCount());
            int[,] resultArray = new int[resultMatrix.GetRowCount(), resultMatrix.GetColumnCount()];

            for (int i = 0; i < resultMatrix.GetRowCount(); i++)
            {
                for (int j = 0; j < resultMatrix.GetColumnCount(); j++)
                {

                    resultArray[i, j] = firstMatrix.GetMatrixArray()[i, j] - secondMatrix.GetMatrixArray()[i, j];
                }
            }
            resultMatrix.SetMatrixArray(resultArray);


            return resultMatrix;
        }

        public override Matrix MatrixMultiply(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix resultMatrix = new Matrix(firstMatrix.GetRowCount(), secondMatrix.GetColumnCount());
            int[,] resultArray = new int[firstMatrix.GetRowCount(), secondMatrix.GetColumnCount()];
            for(int i = 0; i < resultMatrix.GetColumnCount(); i++)
            {
                for(int j = 0; j < resultMatrix.GetColumnCount(); j++)
                {
                    for(int k = 0; k < firstMatrix.GetColumnCount(); k++)
                    {
                        resultArray[i, j] += firstMatrix.GetMatrixArray()[i, k] * secondMatrix.GetMatrixArray()[k, j]; 
                    }
                }
                resultMatrix.SetMatrixArray(resultArray);
            }
            return resultMatrix;

        }


    }
}

