using Alan_Hesaplama;
Shape shape;
int result = 0;
veriAl:
Console.WriteLine("Şekil Seçimi Yapın.");
string[] sekiller = { "Circle", "Triangle", "Square", "Rectangle", "Cube", "Cone", "Pyramid", "Cylinder" };
string[] secenekler = { "Çevre", "Alan", "Hacim" };
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < sekiller.Length; i++)
{
    Console.WriteLine($"{sekiller[i] } için {i + 1} tuşlayın");
}
Console.ForegroundColor = ConsoleColor.Gray;
int.TryParse(Console.ReadLine(), out result);
Console.Clear();
Console.WriteLine($"{result} -> {sekiller[result - 1]} seçildi ");
//switch (result)
//{
//    #region case 1: 
//    case 1:
//        shape = new Circle();
//        break;
//    #endregion
//    #region case 2: 
//    case 2:
//        shape = new Triangle();
//        break;
//    #endregion
//    #region case 3: 
//    case 3:
//        shape = new Square();
//        break;
//    #endregion
//    #region case 4: 
//    case 4:
//        shape = new Rectangle();
//        break;
//    #endregion
//    #region case 5: 
//    case 5:
//        shape = new Cube();
//        break;
//    #endregion
//    #region case 6: 
//    case 6:
//        shape = new Cone();
//        break;
//    #endregion
//    #region case 7: 
//    case 7:
//        shape = new Pyramid();
//        break;
//    #endregion
//    #region case 8: 
//    case 8:
//        shape = new Cylinder();
//        break;
//    #endregion
//    #region case default:
//    default:
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.Write("Lütfen seçim yapın");
//        goto veriAl;
//        #endregion
//}
for (int i = 0; i < secenekler.Length; i++)
{
    Console.WriteLine($"{secenekler[i] } için {i + 1};");
}
int secenek;
int.TryParse(Console.ReadLine(), out secenek);
Console.WriteLine($"{secenek} -> {secenekler[secenek - 1]} seçildi.");

object[] data = { result, secenek };




Console.Read();
