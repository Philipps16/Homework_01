Console.Clear();
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32 (Console.ReadLine());
int Maximal = a;
if (a > Maximal)
{
    Maximal = a;
}
    else if (b > Maximal)
    {
        Maximal = b;
    }
    if (c > Maximal)
    {
        Maximal = c;
    }
  
Console.WriteLine ("Максимальное число из трех: ");
Console.WriteLine (Maximal);