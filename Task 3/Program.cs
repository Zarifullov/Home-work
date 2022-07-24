int x = 0;
int y = 0;
int z = 0;

Console.WriteLine("Введите число x: ");
x = int.Parse(Console.ReadLine());

y = x/2;
string y = Console.ReadLine();

bool y = int.TryParse(y, out z);

if (y)
{
    Console.Write($"{x} - чётное число");
}
if (!y)
{
   Console.Write($"{x} - нечётное число");  
}