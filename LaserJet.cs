using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Menggunakan_Interface
{
    public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nLaserJet display dimension : 12*12");
        }
        public void Print()
        {
            Console.WriteLine("\nLaserJet printer printing....");
        }
    }
}
