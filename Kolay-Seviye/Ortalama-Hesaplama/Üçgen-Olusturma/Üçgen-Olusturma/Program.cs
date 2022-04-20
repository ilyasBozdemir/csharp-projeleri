#region Program.cs
using System.Text;

try
{
    Console.Write("Üçgen uzunluğunu girin : ");
    int length = int.Parse(Console.ReadLine());
    Triangle triangle = Triangle.Create(length);
    
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

#endregion Triangle.cs
public class Triangle
{
    StringBuilder stringLine;
    public static Triangle Create(int length)
    {

        return new Triangle();
    }
}
#region s

#endregion

#region s

#endregion