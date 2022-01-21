using System;

    /// <summary>
    /// Method to adds to vector
    /// </summary>
    class VectorMath
    {
        /// <summary>
        /// Method to adds to vectors
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns>return a new vector with the sum</returns>
        public static double[] Add(double[] vector1, double[] vector2)
        {
            double[] vector = new double[vector1.Length];
            int i = 0;

            if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
            {
                return new double[] { -1 };
            }

            for (i=0; i < vector1.Length; i++)
            {
                vector[i] = vector1[i] + vector2[i];
            }

            return vector;
        }
    }
