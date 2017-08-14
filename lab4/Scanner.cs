using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class Scanner
    {
        public abstract void Scanning();
    }
    class MockScanner:Scanner
    {
        public override void Scanning()
        {
            Console.WriteLine("Pretending to scan");
        }
    }
    class RealScanner : Scanner
    {
        public override void Scanning()
        {
            Console.WriteLine("Really scanning");
        }
    }
}
