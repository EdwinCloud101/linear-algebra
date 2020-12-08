using lib.Matrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class InverseMatrixTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IMatrix matrix = new lib.Matrix.Matrix(2, 2);
            matrix.SetElement(3, 1, 1);
            matrix.SetElement(1, 1, 2);
            matrix.SetElement(4, 2, 1);
            matrix.SetElement(2, 2, 2);

            IMatrix inverseMatrix = new lib.Matrix.Matrix(2, 2);
            inverseMatrix.SetElement(3, 1, 1);
            inverseMatrix.SetElement(1, 1, 2);
            inverseMatrix.SetElement(4, 2, 1);
            inverseMatrix.SetElement(2, 2, 2);

            //IMatrix identityMatrix = new lib.Matrix.Matrix();

            Assert.IsTrue(matrix.Type == MatrixTypeEnum.Squared);
            Assert.IsTrue(inverseMatrix.Type == MatrixTypeEnum.Squared);
        }
    }
}
