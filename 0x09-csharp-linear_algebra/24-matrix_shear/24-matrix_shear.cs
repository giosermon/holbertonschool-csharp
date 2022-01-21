using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int cols_m1 = matrix1.GetLength(1);
        int rows_m1 = matrix1.GetLength(0);
        int cols_m2 = matrix2.GetLength(1);
        int rows_m2 = matrix2.GetLength(0);

        int i, j, k;
        double[,] new_matrix = new double[rows_m1, cols_m2];
        double temp = 0;

               if (rows_m2 != cols_m1)
            return new double[,] { { -1 } };

        for (i = 0; i < rows_m1; i++)
        {
            for (j = 0; j < cols_m2; j++)
            {
                temp = 0;
                for (k = 0; k < cols_m1; k++)
                {
                    temp += matrix1[i, k] * matrix2[k, j];
                }
                new_matrix[i, j] = Math.Round(temp, 2);
            }
        }
        return new_matrix;
    }

    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {

        double[,] basis_vector = new double[,] { { 1, 0 }, { 0 ,1} };
        double[,] _shear = new double[2, 2];
        int i = 0;
        int j = 0;
        int k = 0;

        if (direction != 'X' && direction != 'Y')
            return new double[,] { { -1 } };

        if (direction == 'X')
        {
            basis_vector[1,0] += factor;
        }
        if (direction == 'Y')
        {
            basis_vector[0,1] += factor;
        }

        _shear = Multiply(matrix, basis_vector);

        return _shear;
    }

    /*static void Main(string[] args)
    {
        double[,] m2 = { { 1, 2}, { 3, 4 }};
        double[,] result;
        int i = 0, j = 0;
        char x = 'X';
        char y = 'Y';
        
        result = Shear2D(m2, x, 2.0);

        for (i = 0; i < result.GetLength(0); i++)
        {
            for (j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j]);
                if (j != result.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }*/
}