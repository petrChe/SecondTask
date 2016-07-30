﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProject
{
    class MatrixException : Exception
    {
        public MatrixException() { }

        public MatrixException(string message) : base(message)
        {
        }

        public MatrixException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
