using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Vagon
    {
        public Vagon(VagonEnum type)
        {
            Type = type;
        }

        public VagonEnum Type { get; set; }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
