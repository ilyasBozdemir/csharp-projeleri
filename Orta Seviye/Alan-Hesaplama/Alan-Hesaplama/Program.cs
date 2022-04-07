using Alan_Hesaplama;
Shape shape;
int result = 0;
veriAl:
string[] sekiller = { "Circle", "Triangle", "Square", "Rectangle", "Cube", "Cone", "Pyramid", "Cylinder" };
string[] secenekler = { "Çevre", "Alan", "Hacim" };
Console.ForegroundColor = ConsoleColor.Yellow;


shape = new Circle();

shape.GetPerimeterCalculation();



Console.ReadLine();