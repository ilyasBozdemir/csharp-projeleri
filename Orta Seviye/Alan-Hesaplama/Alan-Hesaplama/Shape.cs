using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public abstract class Shape//Şekil
    {
        ShapeFormulas shapeFormulas;
        public virtual void GetPerimeterCalculation()//çevre
        {
            shapeFormulas = new ShapeFormulas(this);
            double cevre = 0;
            Console.WriteLine("Çevre : " + cevre);
        }
        public virtual void GetAreaCalculation()//alan
        {
            shapeFormulas = new ShapeFormulas(this);
            double alan = 0;
            Console.WriteLine("Alan : " + alan);
        }
        public virtual void GetVolumeCalculation()//hacim
        {
            shapeFormulas = new ShapeFormulas(this);
            double hacim = 0;
            Console.WriteLine("Hacim : " + hacim);
        }
    }
    #region class's
    public class Circle : Shape /*daire*/
    { 
        public Circle()
        {

        }
    }
    public class Triangle : Shape/*üçgen*/
    {
        public Triangle()
        {

        }
    }
    public class Square : Shape/*kare*/
    {
       
        public Square()
        {
            
        }
    }
    public class Rectangle : Shape/*dikdörtgen*/
    {
        public Rectangle()
        {

        }
    }
    public class Cube : Shape/*küp*/
    {
        public Cube()
        {

        }
    }
    public class Cone : Shape/*koni*/
    {
        public Cone()
        {

        }
    }
    public class Pyramid : Shape/*piramit*/
    {
        public Pyramid()
        {

        }
    }
    public class Cylinder : Shape/*silindir*/
    {
        public Cylinder()
        {

        }

    }
    #endregion
}
