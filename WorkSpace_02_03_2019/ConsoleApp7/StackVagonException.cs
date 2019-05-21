using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class StackVagonException : Exception
    {
        public override string ToString()
        {
            return "___Full stack Vagon";
        }
        public override string Message
        {
            get
            {
                return "Full stack Vagon";
            }
        }
    }
}
