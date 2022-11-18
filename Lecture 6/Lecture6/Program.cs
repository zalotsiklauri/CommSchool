
#region task1
using System;
using System.Collections.Generic;

Console.WriteLine("Enter lenght");
int lenght = int.Parse(Console.ReadLine());

int[] array1 = new int[lenght];
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = i + 1;

}
foreach (var item in array1)
{
    Console.Write(item + " ");

}

int[] array2 = new int[lenght];
int[] array3 = new int[lenght];
int arr2index = 0;
int arr3index = 0;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] % 2 == 0)
    {
        array2[arr2index] = array1[i];
        arr2index++;
    }
    else
    {
        array3[arr3index] = array1[i];
        arr3index++;
    }
}

Console.WriteLine();
Console.Write("luwi: ");

for (int i = 0; i < arr2index; i++)
{
    Console.Write(array2[i] + " ");


}
Console.WriteLine();
Console.Write("kenti: ");
for (int i = 0; i < arr3index; i++)
{
    Console.Write(array3[i] + " ");
}
#endregion

#region Task2
Console.WriteLine("Enter array lenght");
int arrlen = int.Parse(Console.ReadLine());
int[] arr1 = new int[arrlen];
Random random = new Random();
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = random.Next(arrlen);
}
Console.Write("Numbers in array: ");
foreach (var item in arr1)
{
    Console.Write(item + " ");
}

Console.WriteLine();

// Using LINQ
var count = from num in arr1
            group num by num
            into num1
            select num1;
foreach (var item in count)
{
    Console.WriteLine($"{item.Key} appears {item.Count()} times sum {item.Key * item.Count()}");
}
Console.ReadLine();
#endregion

#region Task3
List<int> numberList = new List<int>() { };
for (int i = 0; i < 20; i++)
{
    numberList.Add(i + 1);
}

Console.WriteLine("Enter Top Number Count: ");
int topCount = int.Parse(Console.ReadLine());

var sortedList = numberList.OrderByDescending(x => x).Take(topCount).Reverse();
foreach (var item in sortedList)
{
    Console.Write(item + " ");
}
Console.ReadLine();
#endregion