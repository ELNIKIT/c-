using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesBrawl.Main
{
    public class Brawl
    {
        public int ID { get; set; }
        public string Cardnumber { get; set; } = String.Empty;
        public string MMYY { get; set; } = String.Empty;
        public int CVV { get; set; }
        public Brawl() {}
    }
}
