using System;
using System.Collections.Generic;
using System.Text;

namespace lib.Matrix.Diagonal
{
    public class SecondaryDiagonal : SourceDiagonal
    {
        public SecondaryDiagonal(IMatrix matrix) : base(matrix)
        {
            for (int i = 0; i < matrix.Underlying.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.Underlying.GetLength(1); j++)
                {
                    if (i + j == i + 1)
                    {
                        this.Add(matrix.Underlying[i, j]);
                    }
                }
            }
        }
    }
}
