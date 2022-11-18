// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region task3
Console.WriteLine("Enter win : ");
int wins = int.Parse(Console.ReadLine());

Console.WriteLine("Enter draw : ");
int draw = int.Parse(Console.ReadLine());

Console.WriteLine("Enter lose : ");
int lose = int.Parse(Console.ReadLine());

int winCo = 3;
int drawCo = 1;
int loseCo = 0;
int totalSc = 0;

totalSc = wins * winCo + draw * drawCo + lose * loseCo;
//totalSc = totalSc + draw * drawCo;
//totalSc = totalSc + lose * loseCo;

Console.WriteLine(totalSc);
Console.ReadLine();

#endregion

#region task2
List<string> list = new List<string>()
{
    "@",
    "@",
    "@",
    "@",
    "@",
};

int similar = 0;

for (int i = 0; i < list.Count; i++)
{
    Console.Write(list[i] + " ");
    if (list[0] == list[i])
    {
        similar++;
    }
}

Console.WriteLine();

if (similar == list.Count)   
{
    Console.WriteLine(" You Win Jackpot )) ");
}
else
{
    Console.WriteLine("You lose ((: ");
}

Console.ReadLine();

#endregion

#region task6
List<string> list1 = new List<string>()
            {
                "Hello",
                "World",
                "Lecture",
                "Programming",
                "Communication",
                "Football",
                "Baseball",
            };

Console.WriteLine("Enter string size: ");
int size = int.Parse(Console.ReadLine());

var founded = from word in list1
              where word.Length == size
              select word;

if (founded.Count() > 0)
{
    foreach (var item in founded)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("no elements found");
}

Console.ReadLine();
#endregion