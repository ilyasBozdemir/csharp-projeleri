/*#Algoritma
Ekrandan girilen n tane integer ikililerin toplamını alan,
eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran,
sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.
Input: (2 3) (1 5) (2 5) (3 3)^2
Output: 5 6 7 81
*/basaDon:
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("İkili sekilde sayı giriniz.\n"
    + @"Örnek:""2 3"" ""1 5"" ""2 5"" ""3 3"": ");
Console.ForegroundColor = ConsoleColor.Cyan;
string data = Console.ReadLine();
string[] dataArray = data.Split(' ');
if (dataArray.Length % 2 != 0)
{
    Console.Write($"Lütfen İkili Sayı Girin!");
    goto basaDon;
}
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
                toplam = sayi + sayi2;
            }
            else
            {
                toplam = (sayi * sayi) + (sayi2 * sayi2);
            }
            Console.Write($"{toplam} ");
        }
    }
}


Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
