using System;

/// <summary>
/// Method that calculates and returns the length of a given vector.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Methot that returns a magnitud of a given 2D or 3D vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>
    /// The Vector magnitude
    /// </returns>
    public static double Magnitude(double[] vector)
    {
        double sum = 0, magnitude = 0;

        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }

        foreach (double number in vector)
        {
            sum += number*number;
        }
        magnitude = Math.Round(Math.Sqrt(sum), 2);
        return magnitude;
    }
}

