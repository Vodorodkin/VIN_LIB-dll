using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class Continent
    {
        public string name;
        public List<string> vin1;
        public List<Country> countryes;
        public Continent(string name, List<string> vin1, List<Country> countryes)
        {
            this.name = name;
            this.vin1 = vin1;
            this.countryes = countryes;
        }
    }
}
