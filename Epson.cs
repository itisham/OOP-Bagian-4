using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Menggunakan_Interface
{
    public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("\nEpson display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("\nEpson printer printing....");
        }
    }
}
