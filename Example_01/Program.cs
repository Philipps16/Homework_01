Console.Clear();
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32 (Console.ReadLine());
int Maximal = 0;
if (a > b)
{
    Maximal = a;
}
    else
    {
        Maximal = b;
    }
Console.WriteLine ("Максимальное число из двух: ");
Console.WriteLine (Maximal);