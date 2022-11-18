using System;
using System.Collections.Generic;

List<char> myString = new List<char>();
Console.Write("Enter size : ");
int size = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < size; i++)

    
{
    Console.Write("enter the char");
    myString.Add(Convert.ToChar(Console.ReadLine()));

}

Console.WriteLine(socks(myString));

static int socks(List<char> Pairsof)
{
    int similar = 0;
    var Pairsof1 = Pairsof.GroupBy(y => y).ToList();
    foreach (var item in Pairsof1)
    {
        if (item.Count() > 1 && item.Count() % 2 == 0)
        {
            similar += item.Count() / 2; 
        }

        else if (item.Count() > 1 && item.Count() % 2  != 0)
        {
            similar += (item.Count() - 1) / 2;

        }
    }
    return similar;
}

List<string> myString1 = new List<string>() { "Text", "Baseball", "Basketball", "Random" };
foreach (var item in myString1)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
foreach (var item in myString1)
{
    Console.WriteLine(item.ToUpper());
}
List<int> myInt1 = new List<int>() { 1, 2, 3, 4, 5 };
foreach (var item in myInt1)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Generic1(myInt1);

List<bool> myBool1 = new List<bool>() { true, false, true, false, true, false, false };

foreach (var item in myBool1)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Generic1(myBool1);


static void Generic1<T>(List<T> Mylist) {

    if (typeof(T) == typeof(string))
    {
        foreach (var item in Mylist)

        {
            Console.WriteLine(item);
        }
    }
    else if (typeof(T) == typeof(int))

    {
        int sum = 0;
        foreach (var item in Mylist)
        {
            sum += Convert.ToInt32(item);
        }
        Console.WriteLine(sum);
    }
    else if (typeof(T) == typeof(bool))
    {
        Console.WriteLine(Mylist.First());
        Console.WriteLine(Mylist.Last());
        Console.WriteLine(Mylist[Mylist.Count / 2 ]);

    }

}
Console.ReadLine();



