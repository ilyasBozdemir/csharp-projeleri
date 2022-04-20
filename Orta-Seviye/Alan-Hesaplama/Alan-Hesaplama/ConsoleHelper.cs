using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class ConsoleHelper
    {
        public void ReadLine(string text,out double data)
        {
            Console.Write($"{text} ");
            double.TryParse(Console.ReadLine(), out data);
        }
        public void Write(object data)
        {
            Console.Write(data);
        }
    }
}
