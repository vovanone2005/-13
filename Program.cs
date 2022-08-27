Console.WriteLine("Введите число ");
Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a / 100;
int a2 = a %10;
if (a < 99)
{
    Console.WriteLine("Тертьей цифы нет");
}
else
{
    Console.WriteLine( a2 );
}