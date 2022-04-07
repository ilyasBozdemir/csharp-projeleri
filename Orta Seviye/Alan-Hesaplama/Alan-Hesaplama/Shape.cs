using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    //şekil için class yerine struct kullanilabilirdi ama, virtual kullanamadığımoz için class kullandık
    public abstract class Shape//Şekil
    {
        public virtual void GetPerimeterCalculation()//çevre
        {
          
        }
        public virtual void GetAreaCalculation()//alan
        {
           
        }
        public virtual void GetVolumeCalculation()//hacim
        {

        }
    }
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
        public double kenarUzunlugu { get; set; }
        public Square(double kenarUzunlugu,string secenek)
        {
            this.kenarUzunlugu = kenarUzunlugu;
            switch (secenek)
            {
                case "Çevre":

                    break;
                case "Alan":

                    break;
                case "Hacim":

                    break;
                default:
                    break;
            }
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
}
