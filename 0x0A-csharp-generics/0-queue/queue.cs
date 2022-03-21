using System;
/// <summary>
/// Custom generic class Queue
/// </summary>
/// <typeparam name="T">Could be any type</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Checks the type of this generic class.
    /// </summary>
    /// <returns>Returns the type of the generic class.</returns>
    public Type CheckType(){
        return typeof(T).ToString();
    }

}
