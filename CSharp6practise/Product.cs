using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6practise
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public override string ToString() => $"{Code} - {Name}({UnitPrice})";
    }
}
