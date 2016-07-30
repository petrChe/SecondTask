using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProject
{
    class Matrix
    {
        private int rowCount;
        private int columnCount;
        private int[,] matrixArray;

        public Matrix(int rowCount, int columnCount)
        {
            this.rowCount = rowCount;
            this.columnCount = columnCount;
            matrixArray = new int[rowCount, columnCount]; 
        }

        public int GetRowCount()
        {
            return this.rowCount;
        }

        public int GetColumnCount()
        {
            return this.columnCount;
        }

        public void SetRowCount(int value)
        {
            this.rowCount = value;
        }

        public void SetColumnCount(int value)
        {
            this.columnCount = value;
        }

        public int[,] GetMatrixArray()
        {
            return this.matrixArray;
        }

        public void SetMatrixArray(int[,] value)
        {
            this.matrixArray = value;
        }

        public void MatrixToString(Matrix matrix)
        {
            int[,] array = matrix.GetMatrixArray();
            for(int i=0; i < matrix.GetRowCount(); i++)
            {
                string resultString = "";
                for(int j = 0; j < matrix.GetColumnCount(); j++)
                {
                    resultString += array[i, j].ToString() + " ";
                }
                Console.WriteLine(resultString);
            }
        }

        public Matrix invertMatrix(Matrix matrix)
        {
            if(matrix.GetRowCount() == matrix.GetColumnCount())
            {
                for(int i = 0; i < matrix.GetRowCount(); i++)
                {
                    for(int j = i; j < matrix.GetColumnCount(); j++)
                    {
                        int help = matrix.GetMatrixArray()[i, j];
                        matrix.GetMatrixArray()[i, j] = matrix.GetMatrixArray()[j, i];
                        matrix.GetMatrixArray()[j, i] = help;
                    }
                }
            }
            else
            {
                Console.WriteLine("The marix isnt square!!!");
            }
            return matrix;
        }
        
            
        }
    }


