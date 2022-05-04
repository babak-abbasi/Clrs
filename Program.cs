using Clrs.InsertionMethod;

var array = new InsertionMethod(new int[]{5,2,4,6,1,3});

Console.WriteLine("UnSorted");
for(int i=0; i < array.GetArray().Length; i++)
    Console.Write(array.GetArray()[i] + " ,");
array.Sort();
Console.WriteLine(string.Empty);
Console.WriteLine("Sorted");
for(int i=0; i < array.GetArray().Length; i++)
    Console.Write(array.GetArray()[i] + " ,");
