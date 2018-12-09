using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fuel
    {
        private string name;

        public Fuel(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        
        public override string ToString()
        {
            return name;
        }
    }
}
