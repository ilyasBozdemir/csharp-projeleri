using Alan_Hesaplama;
Shape shape;
int result = 0;
veriAl:
string[] sekiller = { "Circle", "Triangle", "Square", "Rectangle", "Cube", "Cone", "Pyramid", "Cylinder" };
string[] secenekler = { "Çevre", "Alan", "Hacim" };
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < sekiller.Length; i++)
{
    Console.WriteLine($"{sekiller[i] } için {i + 1} tuşlayın");
}
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Şekil Seçimi Yapın.");
int.TryParse(Console.ReadLine(), out result);
Console.Clear();
#region switch
switch (result)
{
    #region case 1: 
    case 1:
        shape = new Circle();
        break;
    #endregion
    #region case 2: 
    case 2:
        shape = new Triangle();
        break;
    #endregion
    #region case 3: 
    case 3:
        shape = new Square();
        break;
    #endregion
    #region case 4: 
    case 4:
        shape = new Rectangle();
        break;
    #endregion
    #region case 5: 
    case 5:
        shape = new Cube();
        break;
    #endregion
    #region case 6: 
    case 6:
        shape = new Cone();
        break;
    #endregion
    #region case 7: 
    case 7:
        shape = new Pyramid();
        break;
    #endregion
    #region case 8: 
    case 8:
        shape = new Cylinder();
        break;
    #endregion
    #region case default:
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Lütfen seçim yapın.");
        goto veriAl;
        #endregion
}
#endregion
Console.WriteLine($"{result} -> {sekiller[result - 1]} seçildi ");




Console.ReadLine();