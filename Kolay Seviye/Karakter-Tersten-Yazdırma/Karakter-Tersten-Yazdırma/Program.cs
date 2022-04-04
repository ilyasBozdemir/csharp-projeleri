/*
 #Algoritma
Verilen string ifade içerisindeki karakterleri
bir önceki karakter ile yer değiştiren console uygulamasını yazınız.
Örnek: Input: Merhaba Hello Question
Output: erhabaM elloH uestionQ 
 */

Console.Write("input: ");
string veri = Console.ReadLine();
var dizi = veri.ToArray();
var yeniDizi = dizi.Reverse();
string yeniVeri = string.Join("", yeniDizi);
Console.WriteLine($"Output: {yeniVeri}");
