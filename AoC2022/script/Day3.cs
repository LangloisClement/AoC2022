using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2022.script
{
    class Day3
    {
        List<string> listSac = new List<string>();

        public Day3(string addr)
        {
            if (!File.Exists(addr)) this.listSac = null;
            using (StreamReader file = new StreamReader(addr))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {

                    listSac.Add(ln);
                }
            }
        }

        private List<char> duplicateInBag()
        {
            List<char> items = new List<char>();
            foreach (string sac in listSac)
            {
                string compart1 = sac.Substring(0, sac.Length / 2);
                string compart2 = sac.Substring(sac.Length / 2, sac.Length / 2);
                foreach (char obj in compart1)
                {
                    if (compart2.Contains(obj))
                    {
                        items.Add(obj);
                        break;
                    }
                }
            }
            return items;
        }

        public List<char> group()
        {
            List<char> r = new List<char>();
            for (int i = 0; i < listSac.Count; i += 3)
            {
                List<char> tmp = new List<char>();
                foreach (char obj in listSac[i])
                {
                    if (!tmp.Contains(obj) && listSac[i + 1].Contains(obj))
                    {
                        tmp.Add(obj);
                    }
                }
                foreach (char obj in listSac[i + 2])
                {
                    if (tmp.Contains(obj))
                    {
                        r.Add(obj);
                        break;
                    }
                }
            }
            return r;
        }

        public int Part1
        {
            get => duplicateInBag().ConvertAll(c =>
            {
                int r = (int)c;
                if (r > 96) r -= 96;
                else r = r - 64 + 26;
                return r;
            }).Aggregate(0, (total, next) => total + next);
        }

        public int Part2
        {
            get => group().ConvertAll(c =>
            {
                int r = (int)c;
                if (r > 96) r -= 96;
                else r = r - 64 + 26;
                return r;
            }).Aggregate(0, (total, next) => total + next);
        }
    }
}
