using System;
using Matrix;
class Startup
{
    static void Main()
    {
        Matrix<int> matrix = new Matrix<int>(2, 2);
        matrix[0, 0] = 1;
        matrix[0, 1] = 2;
        matrix[1, 0] = 3;
        matrix[1, 1] = 4;
        Console.WriteLine("Second matrix:\n{0}", matrix);
        Matrix<int> secondMatrix = new Matrix<int>(2, 2);
        secondMatrix[0, 0] = 1;
        secondMatrix[0, 1] = 2;
        secondMatrix[1, 0] = 3;
        secondMatrix[1, 1] = 4;
        Console.WriteLine("Second matrix:\n{0}", secondMatrix);


        Matrix<int> product = matrix * secondMatrix;
        Console.WriteLine("Product of matrix:\n{0}",product);
        Matrix<int> sum = matrix + secondMatrix;
        Console.WriteLine("Sum of matrix:\n{0}", sum);
        Matrix<int> subtract = matrix - secondMatrix;
        Console.WriteLine("Subtraction of matrix:\n{0}", subtract);
    }
}