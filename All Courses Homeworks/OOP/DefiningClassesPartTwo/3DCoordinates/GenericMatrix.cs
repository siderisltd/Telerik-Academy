namespace Coordinates
{
    using System;

    class GenericMatrix<T> where T: IComparable
    {
        T[,] matrix;

        private int row;
        private int col;
        //constructor
        public GenericMatrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
              this.row = rows;
              this.col = cols;
        }
        //indexer with getter and setter
        public T this[int Row, int Col]
        {
            get
            {
                return this.matrix[Row,Col];
            }
            set
            {
                if (this.matrix.GetLength(0).CompareTo(Row) < 0 || this.matrix.GetLength(1).CompareTo(Col) < 0)
                {
                    throw new ArgumentOutOfRangeException("The value is out of the matrix range");
                }
                this.matrix[Row, Col] = value;
            }
        }

        public static GenericMatrix<T> operator +(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.row,firstMatrix.col);
            if (firstMatrix.matrix.GetLength(0) == secondMatrix.matrix.GetLength(0) && firstMatrix.matrix.GetLength(1) == secondMatrix.matrix.GetLength(1))
            {
                for (int rows = 0; rows < firstMatrix.matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < firstMatrix.matrix.GetLength(1); cols++)
                    {
                        var firstMatrixValueToLong = Convert.ToInt64(firstMatrix.matrix[rows, cols]);
                        var secondMatrixValueToLong = Convert.ToInt64(secondMatrix.matrix[rows, cols]);
                        var resultFromAdding = firstMatrixValueToLong + secondMatrixValueToLong;
                        result.matrix[rows, cols] = (T)Convert.ChangeType(resultFromAdding,typeof(T));
                    }
                }
            }
            else
            {
                throw new ArithmeticException("The matrices must be with same sizes!");
            }

            return result;
        }

        public static GenericMatrix<T> operator -(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.row, firstMatrix.col);
            if (firstMatrix.matrix.GetLength(0) == secondMatrix.matrix.GetLength(0) && firstMatrix.matrix.GetLength(1) == secondMatrix.matrix.GetLength(1))
            {
                for (int rows = 0; rows < firstMatrix.matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < firstMatrix.matrix.GetLength(1); cols++)
                    {
                        var firstMatrixValueToLong = Convert.ToInt64(firstMatrix.matrix[rows, cols]);
                        var secondMatrixValueToLong = Convert.ToInt64(secondMatrix.matrix[rows, cols]);
                        var resultFromAdding = firstMatrixValueToLong - secondMatrixValueToLong;
                        result.matrix[rows, cols] = (T)Convert.ChangeType(resultFromAdding, typeof(T));
                    }
                }
            }
            else
            {
                throw new ArithmeticException("The matrices must be with same sizes!");
            }

            return result;
        }

        public static GenericMatrix<T> operator *(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.row, firstMatrix.col);
            if (firstMatrix.matrix.GetLength(0) == secondMatrix.matrix.GetLength(0) && firstMatrix.matrix.GetLength(1) == secondMatrix.matrix.GetLength(1))
            {
                for (int rows = 0; rows < firstMatrix.matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < firstMatrix.matrix.GetLength(1); cols++)
                    {
                        var firstMatrixValueToLong = Convert.ToInt64(firstMatrix.matrix[rows, cols]);
                        var secondMatrixValueToLong = Convert.ToInt64(secondMatrix.matrix[rows, cols]);
                        var resultFromAdding = firstMatrixValueToLong * secondMatrixValueToLong;
                        result.matrix[rows, cols] = (T)Convert.ChangeType(resultFromAdding, typeof(T));
                    }
                }
            }
            else
            {
                throw new ArithmeticException("The matrices must be with same sizes!");
            }

            return result;
        }

        public static bool operator true(GenericMatrix<T> matrix)
        {
           bool isContainZero = false;
                for (int rows = 0; rows < matrix.matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < matrix.matrix.GetLength(1); cols++)
                    {
                        if (matrix.matrix[rows,cols].CompareTo(0) == 0)
                        {
                            isContainZero = true;
                        }
                    }
                }
                return isContainZero;
        }

        public static bool operator false(GenericMatrix<T> matrix)
        {
            return false;
        }
    }
}
