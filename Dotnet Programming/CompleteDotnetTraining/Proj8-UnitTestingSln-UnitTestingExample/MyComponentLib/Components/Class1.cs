using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComponentLib.Components
{
    public class MathComponent
    {
        public long AddNumbers(int input1, int input2)
        {
            long result =  input1 + input2;
            return result;
        }

        public int AddNumbers(int[] input)
        {
            var no = 0;
            foreach (var val in input)
            {
                no += val;
            }
            return no;
        }
    }

    public class MyComparer : IComparer<KeyValuePair<string, string>>
    {
        public int Compare(KeyValuePair<string, string> x, KeyValuePair<string, string> y)
        {
            if (x.Key.CompareTo(y.Key) == 0)
            {
                return x.Value.CompareTo(y.Value);
            }
            else
                return x.Key.CompareTo(y.Key);
        }
    }
    public class Registration
    {
        SortedDictionary<string, string> Zones = new SortedDictionary<string, string>();
        public Registration()
        {
            Zones.Add("Kormangala", "KA01");
            Zones.Add("Yeswanthpur", "KA04");
            Zones.Add("Indiranagar", "KA03");
            Zones.Add("Rajajinagar", "KA02");
            Zones.Add("Jayanagar", "KA05");
            Zones.Add("Tumkur", "KA06");
            Zones.Add("Kolar", "KA07");
            Zones.Add("KGF", "KA08");
            Zones.Add("Mysore", "KA09");
            Zones.Add("Chamrajanagar", "KA10");
            Zones.Add("Mandya", "KA11");
            Zones.Add("Madikeri", "KA12");
            Zones.Add("Hassan", "KA13");
            Zones.Add("Shimoga", "KA14");
            Zones.Add("Sagar", "KA15");
            Zones.Add("Chitradurga", "KA16");
            Zones.Add("Davangere", "KA17");
            Zones.Add("ChikMangalore", "KA18");
            Zones.Add("DK", "KA19");
            Zones.Add("Udupi", "KA20");
            Zones.Add("Puttur", "KA21");
            Zones.Add("Belgaum", "KA22");
            Zones.Add("Chikkodi", "KA23");
            Zones.Add("Bailahongala", "KA24");
            Zones.Add("Dharwad", "KA25");
            Zones.Add("Gadag", "KA26");
            Zones.Add("Haveri", "KA27");
            Zones.Add("Bijapur", "KA28");
            Zones.Add("Bagalkot", "KA29");
            Zones.Add("Karawar", "KA30");
            Zones.Add("Sirsi", "KA31");
            Zones.Add("Gulbarga", "KA32");
            Zones.Add("Yadgiri", "KA33");
            Zones.Add("Bellary", "KA34");
            Zones.Add("Hospet", "KA35");
            Zones.Add("Raichur", "KA36");
            Zones.Add("Gangavathi", "KA37");
            Zones.Add("Bidar", "KA38");
            Zones.Add("Balki", "KA39");
            Zones.Add("Chikka ballapur", "KA40");
            Zones.Add("Rajarajeshwarinagar", "KA41");
            Zones.Add("Ramnagar", "KA42");
            Zones.Add("Devanahalli", "KA43");
            Zones.Add("Tiptur", "KA44");
            Zones.Add("Hunsur", "KA45");
            Zones.Add("Sakaleshpur", "KA46");
            Zones.Add("Honnavar", "KA47");
            Zones.Add("Jamakandi", "KA48");
            Zones.Add("Gokak", "KA49");
            Zones.Add("Yelahanka", "KA50");
            Zones.Add("Electronic City", "KA51");
            Zones.Add("Nelamangala", "KA52");
            Zones.Add("K.R. Puram", "KA53");
            Zones.Add("Nagamangala", "KA54");
            Zones.Add("Mysore East", "KA55");
            Zones.Add("Basavakalyan", "KA56");
            Zones.Add("Shantinagar", "KA57");
            Zones.Add("Banashankari", "KA58");
            Zones.Add("Chamrajpet", "KA59");
            Zones.Add("R.T. Nagar", "KA60");
            Zones.Add("Marathahalli", "KA61");
            Zones.Add("Surathkal", "KA62");
            Zones.Add("Hubli", "KA63");
            Zones.Add("Madhugiri", "KA64");
            Zones.Add("Dandeli", "KA65");
            Zones.Add("Tarikere-Chikkamangalore", "KA66");
            Zones.Add("Chintamani", "KA67");
            Zones.Add("Ranibennur", "KA68");
            Zones.Add("Ramadurga", "KA69");
            Zones.Add("Bantwal", "KA70");
        }

        private string getZone(string reg)
        {
            var zone =  Zones.FirstOrDefault((z) => z.Value == reg).Key;
            if (zone == null) throw new Exception("Invalid Reg No");
            return zone;
        }

        public string[] SortByArea(string [] regNos)
        {
            SortedDictionary<string, string> zones = new SortedDictionary<string, string>();
            foreach (var regNo in regNos)
            {
                var values = regNo.Split('-');
                var no = $"{values[0]}{values[1]}";
                zones.Add(getZone(no), regNo);
            }
            return zones.Values.ToArray();
        }

        public string[] SortByAreaAndNumbers_v2(string[] regNos)
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            foreach(var regNo in regNos)
            {
                var regParts = regNo.Split('-');
                var no = $"{regParts[0]}{regParts[1]}";
                var zone = getZone(no);
                data.Add(new KeyValuePair<string, string>(zone, regNo));
            }

            data.Sort(new MyComparer());
            List<string> allVehicles = new List<string>();
            foreach (var pair in data)
                allVehicles.Add(pair.Value);
            return allVehicles.ToArray();
        }

        public string[] SortByAreaAndNumbers(string [] regNos)
        {
            SortedDictionary<string, string> zones = new SortedDictionary<string, string>();
            List<string> vs = new List<string>();
            foreach (var regNo in regNos)
            {
                var regParts = regNo.Split('-');
                var no = $"{regParts[0]}{regParts[1]}";
                var zone = getZone(no);
                if (zones.ContainsKey(zone))
                {
                    zones[zone] += $",{regNo}";
                }
                else
                {
                    zones.Add(zone, regNo);
                }
            }
            foreach(var pair in zones)
            {
                var values = pair.Value.Split(',');
                var toSort = values.ToList();
                toSort.Sort();
                foreach (var value in toSort)
                    vs.Add(value);
            }
            return vs.ToArray();
        }

    }
}
//Write Test cases for a Repo class: Add, Remove, Update and Delete. 