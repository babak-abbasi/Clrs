using ClrsService.InsertionSort;
using ClrsService.SelectionSort;

var array = new SelectionSort(new int[]{11, 12, 22, 25, 64});
var sortedArray = array.Sort();
foreach (var item in sortedArray)
{
    Console.Write(item + " ");   
}