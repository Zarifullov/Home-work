int a = 0;
int b = 0;
int c = 0;

int max = a;

Console.WriteLine("Введите число a: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число c: ");
c = int.Parse(Console.ReadLine());

if(b > max) max = b;
if(c > max) max = c;
{
  Console.Write($"Максимальное число: {max}");  
}

