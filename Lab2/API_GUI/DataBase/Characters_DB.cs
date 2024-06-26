﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_GUI.DataBase
{
    internal class Characters_DB
    {
        public class Result_DB
        {
            public int Key { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string status { get; set; }
            public string species { get; set; }
            public string type { get; set; }
            public string gender { get; set; }
            public string origin { get; set; }
            public string location { get; set; }
            public string image { get; set; }
            public List<string> episode { get; set; }
            public string url { get; set; }
            public DateTime created { get; set; }

            override public string ToString()
            {
                string s = $"ID: \t\t\t{id}\nName: \t\t\t{name}\nGender: \t\t{gender}\nStatus: \t\t{status}\nSpecies: \t\t{species}\n";
                if (type != "")
                {
                    s += $"Type: \t\t{type}\n";
                }
                s += $"Origin location: \t{origin}\nLast known location: \t{location}\nEpisode count: \t\t{episode.Count}\n";
                return s;
            }
        }
    }
}
