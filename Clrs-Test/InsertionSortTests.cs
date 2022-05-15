using NUnit.Framework;
using ClrsService.InsertionSort;

namespace Clrs_Test;

public class InsertionSortTests
{
    private InsertionSort? array;

    [SetUp]
    public void Setup()
    {
        array = new InsertionSort(new int[]{5,2,4,6,1,3});
    }

    [Test]
    public void InsertionSortTest()
    {
        var sortedArray = new int[]{1,2,3,4,5,6};
        if(array is not null)
        {
            var insertionSorted = array.Sort();
            Assert.That(insertionSorted, Is.EqualTo(sortedArray));
        }
    }

     [Test]
    public void InsertionSortDescendingTest()
    {
        var sortedArray = new int[]{6,5,4,3,2,1};
         if(array is not null)
        {
            var insertionSorted = array.SortDescending();
            Assert.That(insertionSorted, Is.EqualTo(sortedArray));
        }
    }
}