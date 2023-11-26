using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 2, 1, 3, 4, 10, 12, 15 };

        int[] result = Pattern.SortInPattern(inputArray);

        CollectionAssert.AreEqual(result, (new int[] { 1, 15, 2, 12, 3, 10, 4}));

    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] inputArray = Array.Empty<int>();

        int[] result = Pattern.SortInPattern(inputArray);

       CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] inputArray = new int[] { 1 };

        int[] result = Pattern.SortInPattern(inputArray);

        Assert.That(result, Is.EqualTo(new int[] { 1 }));
    }
}
