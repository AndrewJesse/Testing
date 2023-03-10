using System;
using System.Collections.Generic;

// Namespace containing classes for testing SimpleApp
namespace SimpleApp.Tests
{
    // Class for creating Comparer objects
    public class Comparer
    {
        // Static method for creating a new Comparer object
        public static Comparer<U?> Get<U>(Func<U?, U?, bool> func)
        {
            // Returns a new Comparer object with the provided function
            return new Comparer<U?>(func);
        }
    }

    // Generic class that implements IEqualityComparer for comparing objects of type T
    public class Comparer<T> : Comparer, IEqualityComparer<T>
    {
        // Private variable that stores the function to use for comparing objects
        private Func<T?, T?, bool> comparisonFunction;

        // Constructor that initializes the comparisonFunction variable
        public Comparer(Func<T?, T?, bool> func)
        {
            comparisonFunction = func;
        }

        // Implementation of Equals method from IEqualityComparer
        public bool Equals(T? x, T? y)
        {
            // Calls the comparison function to determine if the objects are equal
            return comparisonFunction(x, y);
        }

        // Implementation of GetHashCode method from IEqualityComparer
        public int GetHashCode(T obj)
        {
            // Returns the hash code of the object, or 0 if the object is null
            return obj?.GetHashCode() ?? 0;
        }
    }
}

