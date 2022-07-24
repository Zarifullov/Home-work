int a = 0;
int b = 0;


Console.WriteLine("Введите число a: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
b = int.Parse(Console.ReadLine());

if(a < b)
{
  Console.Write($"max = {b}, min = {a}");  
}

else if(b < a)
{
  Console.Write($"max = {a}, min = {b}");  
}
else
{
Console.Write("Оба числа одинаковые");
}

