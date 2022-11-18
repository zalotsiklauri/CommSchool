// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using lecture_11;
using Newtonsoft.Json;


#region task 1 
string filename = "/Users/zalotsiklauri/Projects/lecture-11/lecture-11/myfile.txt";
Console.WriteLine("Enter line quantity: ");
int Z = int.Parse(Console.ReadLine());

for (int i = 0; i < Z; i++)
{
    File.AppendAllText(filename, Console.ReadLine() + "\r\n");
}

Console.WriteLine("\r\n" + File.ReadAllLines(filename).Last());
Console.ReadLine();
#endregion

#region task2
string fileName = "/Users/zalotsiklauri/Projects/lecture-11/lecture-11/myfiles.txt";
Console.WriteLine("enter n : ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < 10; j++)
    {
        int result = i * j;

        File.AppendAllText(fileName, $"{i} * {j} = {result}\r\n");
        Console.WriteLine($"{i} * {j} = {result}");

    }
    File.AppendAllText(fileName, " \r\n");
    Console.WriteLine();
}
Console.ReadLine();
#endregion
#region task4

string myjsonfile = File.ReadAllText("/Users/zalotsiklauri/Projects/lecture-11/lecture-11/myjson.json");
MyJsonObject myjs = JsonConvert.DeserializeObject<MyJsonObject>(myjsonfile);

myjs.Calculate();
#endregion