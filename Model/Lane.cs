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
        public Vehicle _Vehicle { get; set; }
        public void Clear()
        {
            IsThereRails = false;
            IsThereWires = false;
            _Vehicle = null;
        }
    }
}
