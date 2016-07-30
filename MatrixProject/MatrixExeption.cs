using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProject
{
    class MatrixExeption : ApplicationException
    {
        public MatrixExeption() { }

        public MatrixExeption(string message):base(message) { }

        public MatrixExeption(string message, Exception ex) : base(message, ex) { }
    }
}
