string[] array = new string[4] { "hi", "Hello", "Star", "23" };
int arrayLength = array.Length;
int min = 3; 
int sizeNewArray = CountElementTrue(array);
Console.WriteLine($"Первоначальный массив:");
PrintArray(array);
Console.WriteLine();
if (sizeNewArray > 0)
{
    Console.WriteLine($"После обработки:");
    string[] newArray = new string[sizeNewArray];
    newArray = FilterArray(array, sizeNewArray);
    PrintArray(newArray);
}
else
{
    Console.WriteLine($"В первом массиве нет подходящих элементов меньше или равно{min}");
}
int CountElementTrue(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (arr[i].Length <= min) count++;
    }
    return count;
}
string[] FilterArray(string[] arr, int size)
{
    int k = 0;
    string[] newArr = new string[size];
    for (int i = 0; i < arrayLength; i++)
    {
        if (arr[i].Length <= min)
        {
            newArr[k] = arr[i];
            k++;
        }
    }
    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"'{arr[i]}', ");
        else Console.Write($"'{arr[i]}'");
    }
    Console.WriteLine("]");
}
