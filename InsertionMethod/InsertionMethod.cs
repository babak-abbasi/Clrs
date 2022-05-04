namespace Clrs.InsertionMethod;

class InsertionMethod
{
    private int[] array;

    internal InsertionMethod(int[] _input) => array = _input;

    internal bool Sort()
    {
        int key;
        for(int j = 1; j < array.Length; j++)
        {
            key = array[j];
            int i = j - 1;
            while(i > -1 && array[i] > key)
            {
                array[i + 1] = array[i];
                i--;
            }
            array[i + 1] = key;
        }

        return true;
    }

    internal int[] GetArray() => array;
}