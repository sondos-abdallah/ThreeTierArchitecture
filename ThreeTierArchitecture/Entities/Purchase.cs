using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTierArchitecture.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Wear { get; set; }
        public int Qty { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
    }
}
