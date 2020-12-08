using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using lib.Matrix;
using lib.Matrix.Diagonal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests.Matrix
{
    [TestClass]
    public class DiagonalTests
    {
        [TestMethod]
        public void PrimaryDiagonalTest()
        {
            int order = 3;
            IMatrix matrix = new lib.Matrix.Matrix(order, order);
            int count = 10;
            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                    matrix.SetElement(count, i, j);
                    count++;
                }
            }

            PrimaryDiagonal primaryDiagonal = new PrimaryDiagonal(matrix);
            SecondaryDiagonal secondaryDiagonal = new SecondaryDiagonal(matrix);

            Assert.IsTrue(primaryDiagonal.Sum() == 42);
            Assert.IsTrue(secondaryDiagonal.Sum() == 42);




        }

        [TestMethod]
        public void SecondaryDiagonalTest()
        {

        }
    }
}
