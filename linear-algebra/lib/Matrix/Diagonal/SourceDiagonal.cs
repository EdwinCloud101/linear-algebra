using System;
using System.Collections.Generic;
using System.Text;

namespace lib.Matrix.Diagonal
{
    /// <summary>
    /// Base class for Primary and Secondary Diagonal
    /// </summary>
    public abstract class SourceDiagonal : List<double>
    {
        protected IMatrix Current { get; }

        public SourceDiagonal(IMatrix matrix)
        {
            if (matrix.Type != MatrixTypeEnum.Squared)
                throw new Exception("Not a Squared Matrix");

            Current = matrix;
        }

    }
}
