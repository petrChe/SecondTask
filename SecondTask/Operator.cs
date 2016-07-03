using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    abstract class Operator
    {
        abstract public Matrix MatrixAddition(Matrix firstMatrix, Matrix secondMatrix);
        abstract public Matrix MatrixSubtraction(Matrix firstMatrix, Matrix secondMatrix);
        abstract public Matrix MatrixMultiply(Matrix firstMatrix, Matrix secondMatrix);
    }
}
