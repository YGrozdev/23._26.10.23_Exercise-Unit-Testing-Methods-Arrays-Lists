using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        int num = 1;

        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(num), Throws.ArgumentException); 
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long n = 5;
        long result = PrimeFactor.FindLargestPrimeFactor(n);
        Assert.That(result, Is.EqualTo(5));


    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long n = 123456789123456789;
        long result = PrimeFactor.FindLargestPrimeFactor(n);
        Assert.That(result, Is.EqualTo(52579));
    }
}
