using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] num = new int[3] {1, 2, 3};
        
        
        // Act
               
        int[] result = Duplicates.RemoveDuplicates(num);
        
        // Assert

        Assert.That(result, Is.EqualTo(num));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] num = new int[5] { 1, 2, 2, 3, 3 };


        // Act

        int[] result = Duplicates.RemoveDuplicates(num);

        // Assert

        Assert.That(result, Is.EqualTo(new[] { 1, 2, 3 }));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] num = new int[] { 1, 1, 1, 1 };


        // Act

        int[] result = Duplicates.RemoveDuplicates(num);

        // Assert

        Assert.That(result, Is.EqualTo(new[] { 1 }));
    }
}
