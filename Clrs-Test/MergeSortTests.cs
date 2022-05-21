using NUnit.Framework;
using ClrsService.MergeSort;

class MergeSortTests
{
    private MergeSort mergeSort;

    [SetUp]
    public void SetUp()
    {
        mergeSort = new MergeSort(new int[]{9, 5, 4, 15, 25, 23});
    }

    [Test]
    public void Sort()
    {
        var sortedArray = new int[]{4, 5, 9, 15, 23, 25};
        var mergeSortedArray = mergeSort.Sort();
        Assert.That(mergeSortedArray, Is.EqualTo(sortedArray));
    }
}