int x = 0;

Console.WriteLine("Введите число x: ");
x = int.Parse(Console.ReadLine());



if (x%2 == 0)
{
    Console.Write($"{x} - чётное число");
}
else
{
   Console.Write($"{x} - нечётное число");  
}