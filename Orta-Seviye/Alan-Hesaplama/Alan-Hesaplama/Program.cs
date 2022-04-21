using Alan_Hesaplama;
Shape shape;
int result = -1, result2 = -1;
veriAl:
string[] sekiller = {  "Triangle", "Square", "Rectangle", "Circle", "Cube", "Cone", "Pyramid", "Cylinder" };
string[] secenekler = { "Çevre", "Alan", "Hacim" };
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"not :başlangıc olarak sadece ilk 3 şekil formulleri girilmiştir.");
Console.WriteLine();
for (int i = 0; i < sekiller.Length; i++)
    Console.WriteLine($"{sekiller[i] } için {i + 1} tuşlayın");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Şekil Seçimi Yapın.");
int.TryParse(Console.ReadLine(), out result);
Console.Clear();
if (result < sekiller.Length)
    Console.WriteLine($"{result} -> {sekiller[result - 1]} seçildi.");
#region switch

switch (result)
{
    #region case 1: 
    case 1:
        shape = new Triangle();
        BringOptions(Volume: false);
        break;
    #endregion
    #region case 2: 
    case 2:
        shape = new Square();
        BringOptions(Volume: false);
        break;
    #endregion
    #region case 3: 
    case 3:
        shape = new Rectangle();
        BringOptions(Volume: false);
        break;
    #endregion
    #region case 4: 
    case 4:
        shape = new Circle();
        BringOptions(Volume: false);
        break;
    #endregion
    #region case 5: 
    case 5:
        shape = new Cube();
       
        BringOptions();
        break;
    #endregion
    #region case 6: 
    case 6:
        shape = new Cone();
        BringOptions();
        break;
    #endregion
    #region case 7: 
    case 7:
        shape = new Pyramid();
        BringOptions();
        break;
    #endregion
    #region case 8: 
    case 8:
        shape = new Cylinder();
        BringOptions();
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
void BringOptions(bool Perimeter = true, bool Area = true, bool Volume = true)
{
     secimYap:
    bool[] states = { Perimeter , Area , Volume };
    for (int i = 0; i < states.Length; i++)
        if (states[i])
            Console.WriteLine($"{secenekler[i] } için {i + 1} tuşlayın");
    int.TryParse(Console.ReadLine(), out result2);
    if (result2 < secenekler.Length)
    {
        string SecilenSekil = sekiller[result - 1], SecilenTur = secenekler[result2 - 1];
        Console.WriteLine($"{SecilenSekil} -> {SecilenTur} seçildi.");
        // string[] secenekler = { "Çevre", "Alan", "Hacim" };
        switch (result2)
        {
            case 1:
                shape.GetPerimeterCalculation(); break;
            case 2:
                shape.GetAreaCalculation(); break;
            case 3:
               shape.GetVolumeCalculation(); break;
            default:
                break;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Lütfen seçim yapın.");
        goto secimYap;
    }

}
Console.ReadLine();