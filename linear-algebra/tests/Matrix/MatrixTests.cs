using System.Collections.Generic;
using System.Text;
using lib.Matrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void IsSquareMatrixTest()
        {
            IMatrix matrix = new lib.Matrix.Matrix(2,2);
            Assert.IsTrue(matrix.Type == MatrixTypeEnum.Squared);
        }

        [TestMethod]
        public void IsRowMatrixTest()
        {
            IMatrix matrix = new lib.Matrix.Matrix(1, 5);
            Assert.IsTrue(matrix.Type == MatrixTypeEnum.Row);
        }

        [TestMethod]
        public void IsColumnMatrixTest()
        {
            IMatrix matrix = new lib.Matrix.Matrix(5, 1);
            Assert.IsTrue(matrix.Type == MatrixTypeEnum.Column);
        }
    }


}
