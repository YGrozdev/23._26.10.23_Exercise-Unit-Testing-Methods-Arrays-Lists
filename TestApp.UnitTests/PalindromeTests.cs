using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string>() { "aha", "bob" };
        // Act
        bool result = Palindrome.IsPalindrome(words); 
        // Assert
        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();




        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string>() { "aha" };
        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> words = new List<string>() { "ahaj" };
        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string>() { "Aha" };
        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result);
    }
}
