#region Program.cs
/*
 * 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
 */
try
{
    Console.Write("Fibonacci dizisi uzunluğu girin : ");
    long length = long.Parse(Console.ReadLine());
    Fibonacci fibonacci = FibonacciGenerator.Generator(length);
    FibonacciAverage fibonacciAverage = new FibonacciAverage();
    try
    {
        Console.WriteLine(fibonacciAverage.GetAverage(fibonacci.fibonacciNumbers));
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
    public static Fibonacci Generator(long length)
    {
        Fibonacci fibonacci = new Fibonacci();
        long[] numbers = new long[length];
        long x = 0;
        for (long i = 0; i < length; i++)
        {
            if (i < 2)
            {
                numbers[i] = i;
                x += i;
            }
            else
            {
                long temp = 0;


                numbers[i] = temp;
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