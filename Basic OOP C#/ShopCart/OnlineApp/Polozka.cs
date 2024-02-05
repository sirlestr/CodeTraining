using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    public class Polozka
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
