using System;
/// <summary>
/// Contains all the Method used to handle vectors and matrix
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that multiply a vector * scalar
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns>
    /// returns a new vector with the result
    /// </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] new_vector = new double[vector.Length];

        if (vector.Length < 2 || vector.Length > 3 )
        {
            return new double[] { -1 };
        }

        for (int i = 0; i < vector.Length; i++)
        {
            new_vector[i] = vector[i] * scalar;
        }

        return new_vector;
    }

    /* static void Main(string[] args)
    {
        // Multiply a vector for a scalar v1 = {1, 3, 6} scalar = 4

        double[] vector1 = new double[3] { 1, 3, 6 };
        int scalar = 5;
        double[] mul;

        mul = Multiply(vector1, scalar);

        foreach (double num in mul)
        {
            Console.Write($"{num}, ");
        }
    } */
}

