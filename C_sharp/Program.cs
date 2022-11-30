string[] arr = { "f+qw", "21e", "1d1", "ffa12f", "+1" };
int SizeArray(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) size++;
    }
    return size;
}

int sizeResArray = SizeArray(arr);

string[] resArr = new string[sizeResArray];
int j = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        resArr[j] = arr[i];
        j++;
    }
}

SizeArray(arr);
var stringArr = string.Join(", ", resArr);
System.Console.WriteLine();
Console.WriteLine($"[{stringArr}]");
System.Console.WriteLine();


