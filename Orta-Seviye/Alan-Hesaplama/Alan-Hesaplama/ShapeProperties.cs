using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class ShapeProperties
    {
       
        public static double GetHeight()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();
            double h;
            consoleHelper.ReadLine("Yükseklik Girin :", out h);
            return h;
        }
        public static double GetEdge(byte kenarNo)//kenar
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();
            double e;
            consoleHelper.ReadLine($"{kenarNo}. Kenar Girin :", out e);
            return e;
        }
        public static double GetR()
        {
            ConsoleHelper consoleHelper = new ConsoleHelper();
            double r;
            consoleHelper.ReadLine("Yarıçap Girin :", out r);
            return r;
        }
    }
}
