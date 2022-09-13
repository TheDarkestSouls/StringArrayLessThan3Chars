string[] StringArray = new string[3];

Console.WriteLine("Enter 1st phrase: ");
StringArray[0] = Console.ReadLine();
Console.WriteLine("Enter 2nd phrase: ");
StringArray[1] = Console.ReadLine();
Console.WriteLine("Enter 3rd phrase: ");
StringArray[2] = Console.ReadLine();

StrArray(StringArray);


void StrArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ");
        }
    }
}

// int count(string[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         sum++;
//     }
//     return sum;
// }

// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }