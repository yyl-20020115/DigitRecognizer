﻿using System;

namespace DigitRecognizer;

public static class Utility
{
    /// <summary>
    /// Helper method for displaying progress text to the console for a specific operation.
    /// </summary>
    /// <param name="action">Action</param>
    /// <param name="text">string</param>
    public static T ShowProgressFor<T>(Func<T> action, string text)
    {
        T result;

        Console.Write(text + " .. ");
        result = action();
        Console.WriteLine("Done!");

        return result;
    }
}
