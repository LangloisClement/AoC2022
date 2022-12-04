using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC2022.script
{
    class Day4
    {
        List<string> listPair = new List<string>();

        public Day4(string addr)
        {
            if (!File.Exists(addr)) return;
            using (StreamReader file = new StreamReader(addr))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {

                    listPair.Add(ln);
                }
            }
        }

        bool Overlap1(string pair)
        {
            string a = pair.Split(',')[0];
            int startA = int.Parse(a.Split('-')[0]);
            int endA = int.Parse(a.Split('-')[1]);
            List<int> ids1 = Enumerable.Range(startA, endA - startA + 1).ToList();

            string b = pair.Split(',')[1];
            int startB = int.Parse(b.Split('-')[0]);
            int endB = int.Parse(b.Split('-')[1]);
            List<int> ids2 = Enumerable.Range(startB, endB - startB + 1).ToList();

            int tailleIntersect = ids1.Intersect(ids2).Count();
            return tailleIntersect == ids1.Count || tailleIntersect == ids2.Count;

        }

        bool Overlap2(string pair)
        {
            string a = pair.Split(',')[0];
            int startA = int.Parse(a.Split('-')[0]);
            int endA = int.Parse(a.Split('-')[1]);
            List<int> ids1 = Enumerable.Range(startA, endA - startA + 1).ToList();

            string b = pair.Split(',')[1];
            int startB = int.Parse(b.Split('-')[0]);
            int endB = int.Parse(b.Split('-')[1]);
            List<int> ids2 = Enumerable.Range(startB, endB - startB + 1).ToList();

            return ids1.Intersect(ids2).Any();

        }

        public int Part1 => this.listPair.Count(Overlap1);
        public int Part2 => this.listPair.Count(Overlap2);
    }
}
