using System.Text.RegularExpressions;
using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] new_Matrix = new double[2, 2];
        double[,] transform_Matrix = new double[2, 2];
        double temp = 0;
        int i, j, k;

        if(matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // first define the rotation matrix
        transform_Matrix[0, 0] = Math.Round(Math.Cos(angle), 0);
        transform_Matrix[0, 1] = Math.Round(Math.Sin(angle * -1), 0);
        transform_Matrix[1, 0] = Math.Round(Math.Sin(angle), 0);
        transform_Matrix[1, 1] = Math.Round(Math.Cos(angle), 0);

        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                temp = 0;
                for (k = 0; k < 2; k++)
                {
                    temp += matrix[i, k] * transform_Matrix[k, j];
                }
                new_Matrix[i, j] = Math.Round(temp, 0);
            }
        }
        return new_Matrix;
    }
}
