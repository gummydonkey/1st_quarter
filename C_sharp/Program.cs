string[] arr = { "f+", "213e", "1d1", "ffa12f" };
string[] ResultArray(string[] arr)
{
    int valueCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            valueCount++;
            System.Console.WriteLine(arr[i]);
        }
    }
    System.Console.WriteLine(valueCount);
    string[] resArr = new string[valueCount];
    for (int i = 0; i < arr.Length; i++)
    {
        int j = 0;
        if (arr[i].Length <= 3)
            resArr[j] = arr[i];
        j++;
        System.Console.WriteLine($"{resArr[j]}");
    }
    return resArr;
}

/*void PrintArray(string [] resArr)
{
    for (int i = 0; i < resArr.Length; i++)
    {
        System.Console.WriteLine($"{resArr[i]}");
    }
}
*/
string[] resArr1 = ResultArray(arr);
string resultArray = string.Join(" ", resArr1);
Console.WriteLine(resultArray);