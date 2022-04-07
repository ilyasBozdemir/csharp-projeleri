using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire_Cizdirme
{
    public class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set{ radius = value; }
        }
        private double thickness;
        public double Thickness{ get { return thickness; } set { thickness = value; } }
        public Circle(double radius, double thickness = 0.4) 
        {
            this.Thickness = thickness;
            this.Radius = radius;
        }
        public Circle ()  { }//yapıcı method
        ~Circle() {}//yıkıcı method
    }
    public class DrawCircle
    {
        public StringBuilder GetDraw(Circle circle)
        {
            double rIn = circle.Radius - circle.Thickness,//iç çap
                   rOut = circle.Radius + circle.Thickness;//dış çap
            StringBuilder sb = new StringBuilder ();

            for (double y = circle.Radius; y >= -circle.Radius; --y)// 0,5' -0,5'
            {
                for (double x = -circle.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;// = ( x^2 + y^2 )
                    if (value >= rIn * rIn && value <= rOut * rOut)// ( x^2 + y^2 ) iç çap ve dış çapta ise
                    {
                        sb.Append('*');// karakteri bas
                    }
                    else// (x ^ 2 + y ^ 2) iç çap ve dış çapta değil ise
                    {
                        sb.Append(' ');// boşluk bas
                    }
                }
                sb.AppendLine();//yeni satıra geç
            }
            return sb;
        }
    }

}
