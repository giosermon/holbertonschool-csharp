using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] new_matrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1);j++)
            {
                new_matrix[j, i] = matrix[i, j];
            }
        }
        return new_matrix;
    }
}
