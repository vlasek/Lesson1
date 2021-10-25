// максимальное из двух
int x, y, max;
Console.Write ("Введите первое число: ");
x=Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число: ");
y=Convert.ToInt32 (Console.ReadLine());
if (x>y)
{
    max=x;
}
else
{
    max=y;
    }
Console.Write ("Максимальное число: ");
Console.WriteLine (max);
Console.WriteLine ("максимальное значение: "+max); // второй вариант написания
