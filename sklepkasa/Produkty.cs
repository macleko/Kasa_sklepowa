using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklepik
{
    public class Produkty
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public decimal CenaNetto { get; set; }

        public decimal CenaBrutto => CenaNetto * 1.23m;
    }
}
