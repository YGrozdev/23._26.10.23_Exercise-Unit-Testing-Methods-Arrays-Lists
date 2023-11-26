using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatrixTests
{
    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 } };
        List<List<int>> expected = new() { new() { 6, 8 }, new() { 10, 12 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
    {
        List<List<int>> matrixA = new();
        List<List<int>> matrixB = new();
        List<List<int>> expected = new();

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6, 4 }, new() { 7, 8 } };
        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);
         
    }
    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException2()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new();
        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);

    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException3()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6,}, new() { 7, 8, 4 } };
        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);

    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException4()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 }, new() { 7, 8 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 } };
        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Throws.ArgumentException);

    }

    [Test]  
    public void Test_MatrixAddition_NegativeNumbers_ReturnsCorrectResult()
    {
        List<List<int>> matrixA = new() { new() { -1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, -8 } };
        List<List<int>> expected = new() { new() { 4, 8 }, new() { 10, -4 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
    {
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 0, 0 }, new() { 0, 0 } };


        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(result, Is.EqualTo(matrixA));
    }
}
