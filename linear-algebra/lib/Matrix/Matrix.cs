using System;

namespace lib.Matrix
{
    public interface IMatrix
    {
        int Rows { get; }
        int Columns { get; }
        MatrixTypeEnum Type { get; set; }
        void SetElement(double value, int row, int column);
        double GetElement(int row, int column);
        double[,] Underlying { get; }
        bool GetDeterminant();
    }

    public class Matrix : IMatrix
    {
        public int Rows { get; }
        public int Columns { get; }
        public MatrixTypeEnum Type { get; set; }
        public double[,] Underlying { get; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;

            this.RefreshType();

            if (this.Type != MatrixTypeEnum.None)
                Underlying = new double[rows, columns];
        }
        private void RefreshType()
        {
            bool allElementsZero = false;

            //for (int i = 0; i < Underlying[]; i++)
            //{

            //}

            if (Rows == 0 || Columns == 0)
                this.Type = MatrixTypeEnum.None;
            else if (Rows == Columns)
                this.Type = MatrixTypeEnum.Squared;
            else if (allElementsZero)
                this.Type = MatrixTypeEnum.NullOrZero;
        }



        public bool GetDeterminant()
        {
            if (Type == MatrixTypeEnum.Squared)
            {
                throw new NotImplementedException();
            }

            return false;
        }

        public void SetElement(double value, int row, int column)
        {
            this.Underlying[row, column] = value;
        }

        public double GetElement(int row, int column)
        {
            return this.Underlying[row, column];
        }


    }
}