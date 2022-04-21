using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama.Helpers
{
    public class ShapeHelper//her şekilin çevre formülü farklıdır bunu yapan sınıfımız.
    {

        public static double PerimeterCalculation(Type type)//çevre
        {
            double cevre = 0;//bu kadar if else blokları pek mantıklı değil ama:)
            if ((new Circle()).GetType() == type)
            {

            }
            else if ((new Triangle()).GetType() == type)
            {
                for (int i = 0; i < 3; i++)
                    cevre += ShapeProperties.GetEdge((byte)i);
                
            }
            else if ((new Square()).GetType() == type)
            {

            }
            else if ((new Rectangle()).GetType() == type)
            {

            }
            else if ((new Cube()).GetType() == type)
            {

            }
            else if ((new Cone()).GetType() == type)
            {

            }
            else if ((new Pyramid()).GetType() == type)
            {

            }
            else if ((new Cylinder()).GetType() == type)
            {

            }
            else
            {

            }

            return cevre;
        }

        public static double AreaCalculation(Type type)//alan
        {
            double alan = 0;
            if ((new Circle()).GetType() == type)
            {

            }
            else if ((new Triangle()).GetType() == type)
            {

            }
            else if ((new Square()).GetType() == type)
            {

            }
            else if ((new Rectangle()).GetType() == type)
            {

            }
            else if ((new Cube()).GetType() == type)
            {

            }
            else if ((new Cone()).GetType() == type)
            {

            }
            else if ((new Pyramid()).GetType() == type)
            {

            }
            else if ((new Cylinder()).GetType() == type)
            {

            }
            else
            {

            }


            return alan;
        }
        public static double VolumeCalculation(Type type)//hacim
        {
            double hacim = 0;
            if ((new Circle()).GetType() == type)
            {

            }
            else if ((new Triangle()).GetType() == type)
            {

            }
            else if ((new Square()).GetType() == type)
            {

            }
            else if ((new Rectangle()).GetType() == type)
            {

            }
            else if ((new Cube()).GetType() == type)
            {

            }
            else if ((new Cone()).GetType() == type)
            {

            }
            else if ((new Pyramid()).GetType() == type)
            {

            }
            else if ((new Cylinder()).GetType() == type)
            {

            }
            else
            {

            }

            return hacim;
        }


    }
}
