namespace Matrix
{
    using System;
    using System.Text;

    public class Matrix<T> 
        where T : struct
    {
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public int Rows
        {
            get { return this.matrix.GetLength(0); }
        }

        public int Cols
        {
            get { return this.matrix.GetLength(1); }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException();
            }

            var result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException();
            }

            var result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException();
            }

            var result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] * secondMatrix[i, j];
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        isTrue = false;
                    }
                }
            }

            return isTrue;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isFalse = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        isFalse = false;
                    }
                }
            }

            return isFalse;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    st.AppendFormat("{0} ", this.matrix[i, j]);
                }

                st.AppendLine();
            }

            return st.ToString();
        }
    }
}