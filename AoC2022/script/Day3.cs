using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2022.script
{
    class Day3
    {
        List<Tuple<string, string>> listSac = new List<Tuple<string, string>>();

        public Day3(string addr)
        {
            if (!File.Exists(addr)) this.listSac = null;
            using (StreamReader file = new StreamReader(addr))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string compart1 = ln.Substring(0, ln.Length / 2);
                    string compart2 = ln.Substring(ln.Length / 2, ln.Length / 2);
                    listSac.Add(new Tuple<string, string>(compart1, compart2));
                }
            }
        }
        private List<char> duplicate()
        {
            List<char> items = new List<char>();
            foreach (Tuple<string, string> sac in listSac)
            {
                foreach (char obj in sac.Item1)
                {
                    if (sac.Item2.Contains(obj))
                    {
                        items.Add(obj);
                        break;
                    }
                }
            }
            return items;
        }
        public int Part1
        {
            get
            {
                return duplicate().ConvertAll(c =>
                {
                    int r = (int)c;
                    if (r > 96) r -= 96;
                    else r = r - 64 + 26;
                    return r;
                }).Aggregate(0, (total, next) => total + next);
            }
        }


    }
}
