using System;
using System.Collections.Generic;
using System.Text;

namespace AoC2022.script
{
    class Day2
    {

        public static int part1(string addr)
        {
            if (!System.IO.File.Exists(addr)) return -1;
            string[] temp = System.IO.File.ReadAllLines(addr);
            int score = 0;
            foreach (string round in temp)
            {
                string[] joueur = round.Split(' ');
                if (joueur[1] == "X") //rock
                {
                    score += 1;
                    if (joueur[0] == "A") score += 3; //rock
                    else if (joueur[0] == "C") score += 6; //scissors
                }
                if (joueur[1] == "Y") //paper
                {
                    score += 2;
                    if (joueur[0] == "B") score += 3; //paper
                    else if (joueur[0] == "A") score += 6; //rock
                }
                if (joueur[1] == "Z") //scissors
                {
                    score += 3;
                    if (joueur[0] == "C") score += 3; //scissors
                    else if (joueur[0] == "B") score += 6; //paper
                }
            }
            return score;
        }

        public static int part2(string addr)
        {
            if (!System.IO.File.Exists(addr)) return -1;
            string[] temp = System.IO.File.ReadAllLines(addr);
            int score = 0;
            foreach (string round in temp)
            {
                string[] joueur = round.Split(' ');
                if (joueur[0] == "A") //rock
                {
                    switch (joueur[1])
                    {
                        case "X": //loose
                            score += 0 + 3;
                            break;
                        case "Y": //draw
                            score += 3 + 1;
                            break;
                        case "Z": //win
                            score += 6 + 2;
                            break;
                    }
                }
                else if (joueur[0] == "B") //paper
                {
                    switch (joueur[1])
                    {
                        case "X": //loose
                            score += 0 + 1;
                            break;
                        case "Y": //draw
                            score += 3 + 2;
                            break;
                        case "Z": //win
                            score += 6 + 3;
                            break;
                    }
                }
                else if (joueur[0] == "C") //scissors
                {
                    switch (joueur[1])
                    {
                        case "X": //loose
                            score += 0 + 2;
                            break;
                        case "Y": //draw
                            score += 3 + 3;
                            break;
                        case "Z": //win
                            score += 6 + 1;
                            break;
                    }
                }
            }
            return score;
        }

    }
}
