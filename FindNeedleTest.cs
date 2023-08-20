using NUnit.Framework;
using System;

// Define a test fixture class named FindNeedleTest. Test fixtures are classes that contain test methods.
[TestFixture]
public class FindNeedleTest
{
    // Define a test method named GenericTests.
    // The Test attribute tells NUnit that this is a test method.
    [Test]
    public void GenericTests()
    {
        // Initialize three different haystack arrays for testing.
        // Each haystack contains various types of objects including the string "needle".
        var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
        var haystack_2 = new object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" };
        var haystack_3 = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 };

        // Perform the tests by calling the FindNeedle method from the Kata class.
        // Assert.AreEqual verifies that the expected value matches the actual value returned by FindNeedle.

        // In haystack_1, the "needle" is found at the 3rd index (0-based).
        Assert.AreEqual("found the needle at position 3", Kata.FindNeedle(haystack_1));

        // In haystack_2, the "needle" is found at the 5th index (0-based).
        Assert.AreEqual("found the needle at position 5", Kata.FindNeedle(haystack_2));

        // In haystack_3, the "needle" is found at the 30th index (0-based).
        Assert.AreEqual("found the needle at position 30", Kata.FindNeedle(haystack_3));
    }
}