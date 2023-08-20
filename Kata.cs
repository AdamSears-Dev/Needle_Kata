using System;

public class Kata
{
    // Define a public static method named FindNeedle that takes an array of objects.
    // The function returns a string message indicating the position of the "needle" object if found.
    public static string FindNeedle(object[] haystack)
    {
        // Initialize a variable 'index' with a value of -1.
        // This will be used to store the index position of the "needle" if it is found in the haystack array.
        // The -1 value serves as a default to indicate that the "needle" hasn't been found yet.
        int index = -1;

        // Use a for loop to iterate through the haystack array from start to end.
        // The variable 'i' represents the current index position in the array.
        for (int i = 0; i < haystack.Length; i++)
        {
            // Use the 'is' operator to check if the current object at index 'i' is of type string.
            // If it is, the object is cast to a string and stored in the variable 'str'.
            // The right-hand side of the && operator then compares 'str' to the string "needle".
            if (haystack[i] is string str && str == "needle")
            {
                // If both conditions are met (the object is a string and it equals "needle"),
                // then we've found the "needle" in the haystack.
                // We set 'index' to the value of 'i', representing the position where the "needle" was found,
                // and then break out of the loop since we no longer need to continue searching.
                index = i;
                break;
            }
        }

        // After the loop, check the value of 'index' to determine if the "needle" was found.
        if (index != -1)
        {
            // If 'index' is not -1, then the "needle" was found at that position.
            // Return a message indicating its position in the haystack.
            return $"found the needle at position {index}";
        }
        else
        {
            // If 'index' is still -1, the "needle" was not found in the haystack.
            // Return a message indicating that the "needle" was not found.
            return "needle not found";
        }

    }

    // Main method serving as the entry point for the application
    public static void Main(string[] args)
    {
        // Create a sample haystack array containing various types of objects,
        // including the string "needle"
        object[] sampleHaystack = { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };

        // Call the FindNeedle method and store its return value
        string result = FindNeedle(sampleHaystack);

        // Output the result to the console
        Console.WriteLine(result);
    }
}

// Refactoring Idea:
// The current implementation uses an array of objects. If we were to refactor this to use List<T> from the System.Collections.Generic namespace,
// we could benefit from built-in methods like IndexOf() to find the "needle" without having to manually iterate through the list.
// Using List<string> would allow us to store only string objects and directly use haystack.IndexOf("needle") to find the index, making the code shorter and potentially more readable!

