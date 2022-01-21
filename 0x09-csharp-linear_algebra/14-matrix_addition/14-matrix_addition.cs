using System;
/// <summary>
/// Contains all the Method used to handle matrix 
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method to adds two matrix
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] new_Matrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        int i = 0, j = 0;

        if (matrix1.Length != matrix2.Length)
            return new double[,] { { -1 } };

        for (; i < matrix1.GetLength(0); i++)
        {
            for (j = 0; j < matrix1.GetLength(1); j++)
            {
                new_Matrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        
        return new_Matrix;
    }

    
}
