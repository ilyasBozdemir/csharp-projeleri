var data = Console.ReadLine();
var arrayData = data.Split(" ");
const int deger = 67;
int resultK = 0, resultB = 0;
for (int i = 0; i < arrayData.Length; i++)
{
    var sayi = int.Parse(arrayData[i]);
    if (sayi < deger)
        resultK += (deger - sayi);
    else if (sayi > deger)
    {
        var x = (double)Math.Abs(deger - sayi);
        resultB += (int)Math.Pow(x, 2);
    }
}
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(resultK + " " + resultB);
Console.ForegroundColor = ConsoleColor.White;