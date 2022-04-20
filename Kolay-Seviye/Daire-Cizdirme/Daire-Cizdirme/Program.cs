/* Şekil Çizimi
Kullanıcıdan alınan yarıçapa göre console'a Daire çizen uygulamayı yazınız.
Dikkat Edilmesi Gereken Noktalar :
Kod tekrarından kaçınılmalı
Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.*/
using Daire_Cizdirme;

Basla:
double radius = 5.0,/*yarıçap*/ thickness = 0.4;//kalınlık
Console.Write("Yarıçap girin : ");
bool state = double.TryParse(Console.ReadLine(), out radius);
if (!state || radius < 0)
{
    Console.Write("pozitif değer girin!\n");
    goto Basla;
}

Circle circle = new Circle(radius: radius, thickness: thickness);
DrawCircle drawCircle = new DrawCircle();
var circleData = drawCircle.GetDraw(circle);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n"+circleData);
Console.ForegroundColor = ConsoleColor.Gray;
Console.ReadLine();
