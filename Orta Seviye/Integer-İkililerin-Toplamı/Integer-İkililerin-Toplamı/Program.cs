basaDon:
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("İkili sekilde sayı girin.\n" 
    + @"Örnek:""2 3"" ""1 5"" ""2 5"" ""3 3"": ");
Console.ForegroundColor = ConsoleColor.Cyan;
string data = Console.ReadLine();
string[] dataArray = data.Split(' ');
if (dataArray.Length % 2 != 0)
    goto basaDon;
else
{
    int sayac = 0;
    for (int i = 0; i < dataArray.Length; i++)
    {
        sayac++;
        if (sayac % 2 == 0)
        {
            int sayi = int.Parse(dataArray[i - 1]);
            int sayi2 = int.Parse(dataArray[i]);
            int toplam = 0;
            if (sayi == sayi2)
            {
                var sayiCarpim = (sayi * sayi2);
                toplam = (int)Math.Pow(sayiCarpim, 2);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                toplam = (sayi + sayi2);
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.Write($"{toplam} ");
        }
    }
}
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();


