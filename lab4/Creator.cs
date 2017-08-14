using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class Creator
    {
        public abstract Scanner FactoryMethod();
    }
    class RRSCreator : Creator
    {
        public override Scanner FactoryMethod()
        {
            RealScanner rs = new RealScanner();
            ResizingScanner rss = new ResizingScanner();
            rss.SetScanner(rs);
            return rss;
        }
    }
    class MRSCreator : Creator
    {
        public override Scanner FactoryMethod()
        {
            MockScanner ms = new MockScanner();
            ResizingScanner rss = new ResizingScanner();
            rss.SetScanner(ms);
            return rss;
        }
    }
    class RBSCreator : Creator
    {
        public override Scanner FactoryMethod()
        {
            RealScanner rs = new RealScanner();
            BinScanner rss = new BinScanner();
            rss.SetScanner(rs);
            return rss;
        }
    }
    class MBSCreator : Creator
    {
        public override Scanner FactoryMethod()
        {
            MockScanner ms = new MockScanner();
            BinScanner rss = new BinScanner();
            rss.SetScanner(ms);
            return rss;
        }
    }
}
