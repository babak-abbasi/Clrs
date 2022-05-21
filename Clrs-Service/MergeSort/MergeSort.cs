namespace ClrsService.MergeSort;

public class MergeSort
{
    private int[] array;

    public MergeSort(int[] _array) => array = _array;

    public int[] Sort()
    {
        var result = DivideAndSort(array);

        return result;
    }

    private int[] DivideAndSort(int[] arr)
    {
        if(arr.Length > 1)
        {
            var firstHalf = arr[..(arr.Length/ 2)];
            var secondHalf = arr[(arr.Length / 2)..];
            var firstHalfResult = DivideAndSort(firstHalf);
            var SecondHalfResult = DivideAndSort(secondHalf);
            var sortedArray = InnerSort(firstHalfResult, SecondHalfResult);

            return sortedArray;
        }
        else
            return arr;
    }

    private int[] InnerSort(int[] firstArray, int[] secondArray)
    {
        var arr = new int[firstArray.Length + secondArray.Length];
        int firstCounter = 0, secondCounter = 0, arrCounter = 0;

        while(firstCounter < firstArray.Length && secondCounter < secondArray.Length)
        {
            if(firstArray[firstCounter] <= secondArray[secondCounter])
                arr[arrCounter++] = firstArray[firstCounter++];
            else arr[arrCounter++] = secondArray[secondCounter++];
        }

        if(firstCounter == firstArray.Length)
            for (int i = secondCounter; i < secondArray.Length; i++)
                arr[arrCounter++] = secondArray[secondCounter++];
        else
            for (int i = firstCounter; i < firstArray.Length; i++)
                arr[arrCounter++] = firstArray[firstCounter++];

        return arr;
    }
}