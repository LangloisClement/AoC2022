using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace AoC2022.script
{
    class Day1
    {

        public static int part1(string addr)
        {
            if (!File.Exists(addr)) return -1;
            List<List<int>> listElfe = new List<List<int>>
            {
                new List<int>()
            };
            using (StreamReader file = new StreamReader(addr))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    if (ln == "") listElfe.Add(new List<int>());
                    else
                    {
                        int item = Int32.Parse(ln);
                        listElfe[^1].Add(item);
                    }
                }
            }
            List<int> listPoids = listElfe.ConvertAll(x => x.Aggregate(0, (total, next) => total + next));
            return listPoids.Max();
        }
    }
}
