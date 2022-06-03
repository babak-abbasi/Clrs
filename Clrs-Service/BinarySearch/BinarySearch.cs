namespace ClrsService.BinarySearch;

public class BinarySearch
{
    private int[] sortedArray;
    public BinarySearch(int[] _sortedArray)
    {
        sortedArray = _sortedArray;
    }

    public bool Find(int value)
    {
        var isFound = false;
        var halfValue = sortedArray[sortedArray.Length / 2];

        if(value == halfValue)
            isFound = true;
        else if(value > halfValue && sortedArray.Length > 1){
            sortedArray = sortedArray[(sortedArray.Length / 2)..];
            isFound = Find(value);
        } else if(value < halfValue && sortedArray.Length > 1){
            sortedArray = sortedArray[..(sortedArray.Length / 2)];
            isFound = Find(value);
        }

        return isFound;
    }
}