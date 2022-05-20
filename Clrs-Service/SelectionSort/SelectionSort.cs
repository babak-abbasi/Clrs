namespace ClrsService.SelectionSort;

public class SelectionSort
{
    private int[] _array;

    public SelectionSort(int[] input) => _array = input;

    public int[] Sort()
    {
        int tempIndex = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            tempIndex = i;
            for (int j = i+1; j < _array.Length; j++)
            {
                if(_array[tempIndex] > _array[j])
                    tempIndex = j;
                
            }
            int temp = _array[i];
            _array[i] = _array[tempIndex];
            _array[tempIndex] = temp;
        }

        return _array;
    }
}