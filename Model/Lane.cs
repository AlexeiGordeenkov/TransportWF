using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lane
    {
        public bool IsThereRails()
        {
            if(_Vehicle==null)return false;

            if (_Vehicle.GetType().Name.Equals("Tram")) return true;
            return false;
        }
        public bool IsThereWires()
        {
            if (_Vehicle == null) return false;
            if (_Vehicle.GetType().Name.Equals("TroleyBus")) return true;
            return false;
        }
        public Vehicle _Vehicle { get; set; }
        public void Clear()
        {
            _Vehicle = null;
        }
    }
}
