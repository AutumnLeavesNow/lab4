using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class Decorator:Scanner
    {
        protected Scanner scanner;

        public void SetScanner(Scanner scanner)
        {
            this.scanner = scanner;
        }
        public override void Scanning()
        {
            if (scanner != null)
            {
                scanner.Scanning();
            }
        }
    }

    class ResizingScanner : Decorator
    {
        public override void Scanning()
        {
            base.Scanning();
            Console.WriteLine("Resizing");
        }

    }
    class BinScanner : Decorator
    {
        public override void Scanning()
        {
            base.Scanning();
            Console.WriteLine("Binning");
        }

    }
}
