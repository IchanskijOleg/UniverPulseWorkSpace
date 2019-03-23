using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyNews
{
    public class News
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public DateTime Time { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{City}, {Id}, {Info}, {Time}";
        }
    }
}
