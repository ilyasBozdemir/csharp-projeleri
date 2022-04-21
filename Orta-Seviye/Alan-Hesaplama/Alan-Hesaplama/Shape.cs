using Alan_Hesaplama.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public  class Shape//Şekil
    {
        public Type _type;
        public virtual void GetPerimeterCalculation()//çevre
        {
            _type = this.GetType();
            double cevre = ShapeHelper.PerimeterCalculation(this.GetType());
            Console.WriteLine($"Çevre : {cevre} ");
        }
        public virtual void GetAreaCalculation()//alan
        {
            double alan = ShapeHelper.AreaCalculation(this.GetType());

            Console.WriteLine($"Alan : {alan}");
        }
        public virtual void GetVolumeCalculation()//hacim
        {
            double hacim = ShapeHelper.VolumeCalculation(this.GetType());
            Console.WriteLine($"Hacim : {hacim}");
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
