using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Methods
    {
        public static string GetVINCountry(string vin)
        {
            string vin1 = vin[0].ToString();
            string vin2 = vin[1].ToString();
            
            foreach (Continent continent in Vin_info.Continents)
                if (continent.vin1.Contains(vin1))
                    foreach (Country country in continent.countryes)
                        if (country.vin1 == vin1 && country.vin2.Contains(vin2)) return country.name;           
            return "Не найдено";
        }
        public static bool CheckVIN(string vin)
        { 

            
            if (char.IsDigit(vin[8]))
            {              
                int weight = Vin_info.digAlf.Find(x => x.letter == vin[0]).num *  8 +
                             Vin_info.digAlf.Find(x => x.letter == vin[1]).num *  7 +
                             Vin_info.digAlf.Find(x => x.letter == vin[2]).num *  6 +
                             Vin_info.digAlf.Find(x => x.letter == vin[3]).num *  5 +
                             Vin_info.digAlf.Find(x => x.letter == vin[4]).num *  4 +
                             Vin_info.digAlf.Find(x => x.letter == vin[5]).num *  3 +
                             Vin_info.digAlf.Find(x => x.letter == vin[6]).num *  2 +
                             Vin_info.digAlf.Find(x => x.letter == vin[7]).num *  10 +
                             Vin_info.digAlf.Find(x => x.letter == vin[9]).num *  9 +
                             Vin_info.digAlf.Find(x => x.letter == vin[10]).num * 8 +
                             Vin_info.digAlf.Find(x => x.letter == vin[11]).num * 7 +
                             Vin_info.digAlf.Find(x => x.letter == vin[12]).num * 6 +
                             Vin_info.digAlf.Find(x => x.letter == vin[13]).num * 5 +
                             Vin_info.digAlf.Find(x => x.letter == vin[14]).num * 4 +
                             Vin_info.digAlf.Find(x => x.letter == vin[15]).num * 3 +
                             Vin_info.digAlf.Find(x => x.letter == vin[16]).num * 2                             
                             ;
                int a = weight / 11 * 11;

                if (int.Parse(vin[8].ToString()) == (weight - a)) return true;
                else if (int.Parse(vin[8].ToString()) == 0)
                    if (10 == (weight - a)) return true;
                    else return false;
                else return false;
            }
            else if (vin[8]=='X')
            {
                int weight = Vin_info.digAlf.Find(x => x.letter == vin[0]).num * 8 +
             Vin_info.digAlf.Find(x => x.letter == vin[1]).num * 7 +
             Vin_info.digAlf.Find(x => x.letter == vin[2]).num * 6 +
             Vin_info.digAlf.Find(x => x.letter == vin[3]).num * 5 +
             Vin_info.digAlf.Find(x => x.letter == vin[4]).num * 4 +
             Vin_info.digAlf.Find(x => x.letter == vin[5]).num * 3 +
             Vin_info.digAlf.Find(x => x.letter == vin[6]).num * 2 +
             Vin_info.digAlf.Find(x => x.letter == vin[7]).num * 10 +
             Vin_info.digAlf.Find(x => x.letter == vin[9]).num * 9 +
             Vin_info.digAlf.Find(x => x.letter == vin[10]).num * 8 +
             Vin_info.digAlf.Find(x => x.letter == vin[11]).num * 7 +
             Vin_info.digAlf.Find(x => x.letter == vin[12]).num * 6 +
             Vin_info.digAlf.Find(x => x.letter == vin[13]).num * 5 +
             Vin_info.digAlf.Find(x => x.letter == vin[14]).num * 4 +
             Vin_info.digAlf.Find(x => x.letter == vin[15]).num * 3 +
             Vin_info.digAlf.Find(x => x.letter == vin[16]).num * 2
             ;
                int a = weight / 11 * 11;
                if (10 == (weight - a)) return true;
                else return false;
            }
            else return false;
        }
        public static int GetTransportYear(string vin)
        {

            return int.Parse( Vin_info.Yalf.FindAll(x => x.letter == vin[9])[0].year.ToString()+ Vin_info.Yalf.FindAll(x => x.letter == vin[9])[1].year.ToString());
            
                     
        }
    }
}
