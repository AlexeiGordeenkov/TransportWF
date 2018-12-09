using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fuel
    {
        private string Name;

        public Fuel(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
