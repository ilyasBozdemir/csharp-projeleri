using Alan_Hesaplama;
Shape shape;
int result = -1, result2 = -1;
veriAl:
string[] sekiller = { "Circle", "Triangle", "Square", "Rectangle", "Cube", "Cone", "Pyramid", "Cylinder" };
string[] secenekler = { "Çevre", "Alan", "Hacim" };
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < sekiller.Length; i++)
    Console.WriteLine($"{sekiller[i] } için {i + 1} tuşlayın");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Şekil Seçimi Yapın.");
int.TryParse(Console.ReadLine(), out result);
Console.Clear();
Console.WriteLine($"{result} -> {sekiller[result - 1]} seçildi ");
#region switch

switch (result)
{
    #region case 1: 
    case 1:
        shape = new Circle();
        BringOptions();
        break;
    #endregion
    #region case 2: 
    case 2:
        shape = new Triangle();
        BringOptions(Volume: false);
        break;
    #endregion
    #region case 3: 
    case 3:
        shape = new Square();
        BringOptions(Volume: false);
        break;
    #endregion
    #region case 4: 
    case 4:
        shape = new Rectangle();
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
    //
    //if (Perimeter)
    //    Console.WriteLine($"{secenekler[0] } için {1} tuşlayın");
    //if (Area)
    //    Console.WriteLine($"{secenekler[1] } için {2} tuşlayın");
    //if (Volume)
    //    Console.WriteLine($"{secenekler[2] } için {3} tuşlayın");
    //
    bool[] states = { Perimeter , Area , Volume };//yukardaki gibi yazmak sacamlık o yuzden asagıdaki kullanım dogrudur
    for (int i = 0; i < states.Length; i++)
    {
        if (states[i])
            Console.WriteLine($"{secenekler[i] } için {i + 1} tuşlayın");
    }
    int.TryParse(Console.ReadLine(), out result2);
    switch (result2)
    {
        #region case 1: 
        case 1:
         
            break;
        #endregion
        #region case 2: 
        case 2:
           
            break;
        #endregion
        #region case 3: 
        case 3:
            
            break;
        #endregion
        #region case default:
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Lütfen seçim yapın.");
            goto secimYap;
            #endregion
    }

}
Console.ReadLine();