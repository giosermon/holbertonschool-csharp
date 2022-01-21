using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] new_matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
        int i, j;

        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3
        || matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
        {
            return new double[,] { { -1 } };
        }

        for(i=0; i<matrix.GetLength(0); i++)
        {
            for(j=0; j< matrix.GetLength(1); j++)
            {
                new_matrix[i, j] = matrix[i, j] * scalar;
            }
        }
        return new_matrix;
    }
}
