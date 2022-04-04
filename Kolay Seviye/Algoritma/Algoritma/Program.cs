/*#Algoritma
Ekrandan bir string bir de sayı alan (aralarında virgül ile),ilgili string ifade içerisinden verilen indexteki
karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.
Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0
Output:       Algritma Algortma Algoritma lgoritma 
 */
Console.Write("input : ");
string data = Console.ReadLine();
string[] parcalar = data.Split(' ');//boşluk ile ayırdık.
List<string> datas = new List<string>();
for (int x = 0; x < parcalar.Length; x++)
{
    var dizi = parcalar[x].Split(',');//Algoritma,3
    data = dizi[0];//Algoritma
    int sayi = int.Parse(dizi[1]);//3
    var dataToChar = data.ToArray();// [A,l,g,o,r,i,t,m,a]
    if (dataToChar.Length <= sayi)
        datas.Add(String.Join("", dataToChar));
    else
    {
        Array.Clear(dataToChar, sayi, 1);
        datas.Add(String.Join("", dataToChar));
    }
}
foreach (var item in datas)
    Console.Write(item + " ");
Console.Write("\n");


