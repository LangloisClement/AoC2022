using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AoC2022.script
{
    class Day5
    {
        static Regex regex = new Regex(@"move (\d+) from (\d+) to (\d+)");

        List<int[]> listMouvement = new List<int[]>();
        public Day5(string addr)
        {
            List<string> matrice = new List<string>();
            bool flag = false;
            if (!File.Exists(addr)) return;
            using (StreamReader file = new StreamReader(addr))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    if (!flag && ln == "")
                    {
                        flag = true;
                        continue;
                    }
                    if (!flag) matrice.Add(ln);
                    else
                    {
                        Match r = regex.Match(ln);
                        listMouvement.Add(new int[3] { int.Parse(r.Groups[1].Value), int.Parse(r.Groups[2].Value), int.Parse(r.Groups[3].Value) });
                    }
                }
            }
        }
    }
}
