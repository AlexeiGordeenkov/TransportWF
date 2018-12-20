using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lane
    {
        public bool IsThereRails { get; set; }
        public bool IsThereWires { get; set; }
        public Vehicle Vehicle { get; set; };
    }
}
