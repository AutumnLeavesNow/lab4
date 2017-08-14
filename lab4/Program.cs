using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator myCreator = new RBSCreator();
            Scanner myScanner = myCreator.FactoryMethod();
            myScanner.Scanning();
            Root root = new Root(@"D:\Adrien", 1233, "Zzzz");
            root.Display(1);
            Console.Read();
        }
    }
}
