using NUnit.Framework;
using ClrsService.SelectionSort;

namespace Clrs_Test;

public class SelectionSortTests
{
    private SelectionSort? array;

    [SetUp]
    public void Setup()
    {
        array = new SelectionSort(new int[] { 64, 25, 12, 22, 11});
    }

    [Test]
    public void SelectionSortTest()
    {
        var sortedArray = new int[]{11, 12, 22, 25, 64};
        if(array is not null)
        {
            var selectionSort = array.Sort();
            Assert.That(selectionSort, Is.EqualTo(sortedArray));
        }
    }
}