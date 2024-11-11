try
{
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите  n: ");
    int n = int.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 0; i <= n; i += 2)
    {
        i += 2;
        int factorial = 1;
            factorial *= i;
        double term = Math.Pow((2 * x), i) / factorial;
        if ((i / 2) % 2 == 0)
        {
            s += term;
        }
        else
        {
            s -= term;
        }
    }
    Console.WriteLine($"Сумма ряда: {s}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
