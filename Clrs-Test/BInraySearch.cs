using NUnit.Framework;
using ClrsService.BinarySearch;
using System;

[TestFixture]
public class BinarySearchTest
{
    [Test]
    public void Find_BinarySearch_NotFound()
    {
        var binarySearch = new BinarySearch(new int[]{2, 5, 8, 112, 125, 250});
        var result = binarySearch.Find(20);

        Assert.AreEqual(result, false);
    }

    [Test]
    public void Find_BinarySearch_Found()
    {
        var binarySearch = new BinarySearch(new int[]{2, 5, 8, 112, 125, 250});
        var result = binarySearch.Find(250);

        Assert.AreEqual(result, true);
    }
}