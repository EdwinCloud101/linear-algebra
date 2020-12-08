using System;
using System.Collections.Generic;
using System.Text;
using lib.Matrix.Diagonal;

namespace lib.Matrix
{
    public class PrimaryDiagonal : SourceDiagonal
    {
        public PrimaryDiagonal(IMatrix matrix) : base(matrix)
        {
            for (int i = 0; i < matrix.Underlying.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.Underlying.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        this.Add(matrix.Underlying[i, j]);
                    }
                }
            }
        }
    }
}
