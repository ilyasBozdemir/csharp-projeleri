string sesliHarfler = "aeıioöuü";
Console.Write("Metni Girin: ");
var data = Console.ReadLine();
var dataArr = data.Split(' ');
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < dataArr.Length; i++)
    Console.Write($"{IkıTaneSessizHarfYanYanaMi(dataArr[i])} ");
Console.ForegroundColor = ConsoleColor.Gray;
Console.Read();

bool IkıTaneSessizHarfYanYanaMi(string data)
{
    byte sayac = 0;
    bool state = false;
    foreach (var item in data.ToLower())
    {
        state = sesliHarfler.Contains(item);
        if (!state)
        {
            sayac++;
            if (sayac == 2)
                return true;
        }
        else
            sayac = 0;///sesli harf görürsen 0'la
    }
    return state;
}
