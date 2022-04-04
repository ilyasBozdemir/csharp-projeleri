#region Program.cs
try
{
    Console.Write("Fibonacci dizisi uzunluğu girin : ");
    long length = long.Parse(Console.ReadLine());
    Fibonacci fibonacci = FibonacciGenerator.Generator(length);
    FibonacciAverage fibonacciAverage = new FibonacciAverage();
    try
    {
        Console.Write("fibonacciAverage : ");
        Console.Write(fibonacciAverage.GetAverage(fibonacci.fibonacciNumbers));
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion
#region Fibonacci.cs
public class Fibonacci
{
    public Fibonacci() { }
    public long[] fibonacciNumbers { get;  set; }

}
#endregion
# region FibonacciGenerator.cs
public class FibonacciGenerator
{
    /* 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377*/
    public static Fibonacci Generator(long length)
    {
        Fibonacci fibonacci = new Fibonacci();
        long[] numbers = new long[length];

        int ilk = 1;
        int son = 1;
        int toplam;

        for (long i = 1; i < length; i++) 
        {
            if (i < 2)
            {
                numbers[0] = ilk;
                numbers[1] = son;
            }
            else
            {
                toplam = ilk + son;
                ilk = son;
                son = toplam;
                numbers[i] = toplam;
            }
        }

        fibonacci.fibonacciNumbers = numbers;
        return fibonacci;
    }
   
}
#endregion
#region FibonacciAverage
public class FibonacciAverage
{
    public long GetAverage(long[] FibonacciArray)
    {
        long avarage = 0;
        foreach (var item in FibonacciArray)
        {
            avarage += item;
        }
        return avarage;
    }
}
#endregion