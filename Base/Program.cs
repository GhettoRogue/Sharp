Console.Write("Введите 1 число: ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
var num2 = Convert.ToInt32(Console.ReadLine());

// var result = num1 + num2;
//
// Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

if (num2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Делить на ноль нельзя!!!");
    Console.ResetColor();
}
else
{
    var result = (double)num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {result}");
}

///////////////////////////////////////////////////////////////////

var array = new int[10];
var list = new List<int>();

var random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11);
    list.Add(array[i]);
}

Console.Write("[ ");
foreach (var item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");

Console.Write("{ ");
foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine("}");

///////////////////////////////////////////////////////////////////

var array = new int[10];
var list = new List<int>();

var random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11);
    list.Add(array[i]);
}

Console.Write("[ ");
foreach (var item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");

Console.Write("{ ");
foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine("}");

///////////////////////////////////////////////////////////////////

const int SIZE = 10;
var list = new List<int>();
var random = new Random();
for (int i = 0; i < SIZE; i++)
{
    list.Add(random.Next(-10, 11));
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("{ ");
foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine("}");
Console.ResetColor();

var array = list.ToArray();
Array.Reverse(array);

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("[ ");
foreach (var item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine("]");
Console.ResetColor();

list.Reverse();
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("{ ");
foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine("}");
Console.ResetColor();

var distinkt = list.Distinct();
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("{ ");
foreach (var item in distinkt)
{
    Console.Write($"{item} ");
}
Console.WriteLine("}");
Console.ResetColor();

