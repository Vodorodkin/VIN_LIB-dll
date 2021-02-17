using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Country
    {
        public string name;
        public string vin1;
        public List<string> vin2;
        public Country(string name, string vin1, List<string> vin2)
        {
            this.name = name;
            this.vin1 = vin1;
            this.vin2 = vin2;
        }
    }
}
