﻿using System;

class ThrowingExceptions
{
    public static double Sqrt(double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException("Sqrt for negative numbers is undefined!");
        }

        return Math.Sqrt(value);
    }

    static void Main()
    {
        try
        {
            Sqrt(-1);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Error: {0}", ex.Message);
            throw;
        }
    }
}
