using NUnit.Framework;
using ClrsService.InsertionMethod;

namespace Clrs_Test;

public class InsertionMethodTests
{
    private InsertionMethod array;

    [SetUp]
    public void Setup()
    {
        array = new InsertionMethod(new int[]{5,2,4,6,1,3});
    }

    [Test]
    public void InsertionMethodTest()
    {
        var sortedArray = new int[]{1,2,3,4,5,6};
        var insertionSorted = array.Sort();

        Assert.That(insertionSorted, Is.EqualTo(sortedArray));
    }
}