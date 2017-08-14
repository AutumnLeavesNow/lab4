using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class FSVertex
    {
        public string Path { get; private set; }
        public FSVertex (string path)
        {
            Path = path;
        }
        public abstract void Display(int depth);
    }
    class Root : FSVertex
    {
        public int DiskSize { get; private set;}
        public string CatalogueName { get; private set; }
        private Folder mainFolder;
        public Root(string path, int dSize, string catName) : base(path)
        {
            mainFolder = new Folder(path);
            DiskSize = dSize;
            CatalogueName = catName;
        }
        public override void Display(int depth)
        {
            Console.WriteLine("Root catalogue {0} with capacity of {1}", CatalogueName, DiskSize);
            mainFolder.Display(depth);
        }
    }
    class File : FSVertex
    {
        public string Extention { get; private set; }
        public File(string path) : base(path)
        {
            string[] pathAndExt = path.Split('.');
            if (pathAndExt.Length < 2)
                throw new IOException();
            Extention = pathAndExt[1];
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Path );
        }
    }
    class Folder : FSVertex
    {
        private List<FSVertex> children = new List<FSVertex>();
        public Folder(string path) : base(path)
        {
            string [] childrenpaths;
            string[] childDirs;
            try
            {
                childrenpaths = Directory.GetFiles(Path);
                childDirs = Directory.GetDirectories(Path);
            }
            catch(IOException e)
            {
                throw e;
            }
            foreach (string childpath in childrenpaths)
            {
                children.Add(new File(childpath));
            }
            foreach (string childpath in childDirs)
            {
                children.Add(new Folder(childpath));
            }

        }
        
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Path);

            // Recursively display child nodes
            foreach (FSVertex component in children)
            {
                component.Display(depth + 1);
            }
        }

    }
}
