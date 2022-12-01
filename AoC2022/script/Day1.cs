using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace AoC2022.script
{
    class Day1
    {
        private List<List<int>> listElfe;
        List<int> listPoids;

        public Day1(string addr)
        {
            if (!File.Exists(addr)) this.listElfe = null;
            this.listElfe = new List<List<int>>
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
            listPoids = this.listElfe.ConvertAll(x => x.Aggregate(0, (total, next) => total + next));
            listPoids.Sort();

        }

        public int Part1 => listPoids[^1];

        public int Part2 => listPoids[^3] + listPoids[^2] + listPoids[^1];
    }
}
