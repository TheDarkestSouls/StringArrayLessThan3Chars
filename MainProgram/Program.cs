string[] StringArray = new string[3];

Console.WriteLine("Enter 1st phrase: ");
StringArray[0] = Console.ReadLine();
Console.WriteLine("Enter 2nd phrase: ");
StringArray[1] = Console.ReadLine();
Console.WriteLine("Enter 3rd phrase: ");
StringArray[2] = Console.ReadLine();


ShowArray(StrArray(StringArray));


string[] StrArray(string[] array)
{
    string[] result = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[temp] = array[i];
            temp++;
        }
    }
    return result;
}

void ShowArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
