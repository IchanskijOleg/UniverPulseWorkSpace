using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    public static class Creator
    {
        public static void SaveToFile(StackVagon train, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                while (!train.IsEmpty())
                    sw.WriteLine((int)train.Pop().Type);
            }
        }
        public static void Create(out StackVagon train, int n)
        {
            train = new StackVagon();
            Random r = new Random();
            while (n != 0)
            {
                train.Push(new Vagon((VagonEnum)r.Next(0, 2)));
                n--;
            }
        }
        public static void ReadFromFile(out StackVagon train, string filename)
        {
            train = new StackVagon();
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    //int type = int.Parse(sr.ReadLine());
                    string strparams = sr.ReadLine();
                    string[] p = strparams.Split('=');
                    int typeVagon = -1;
                    if (p[0] == "type")
                    {
                        typeVagon = int.Parse(p[1]);
                        train.Push(new Vagon((VagonEnum)typeVagon));
                    }
                }
            }
        }
    }
}
