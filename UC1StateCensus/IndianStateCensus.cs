using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UC1StateCensus
{
    class IndianStateCensus : StateCensusModel
    {
        StateCensusModel census;
        public Dictionary<string, StateCensusModel> dataMap = new Dictionary<string, StateCensusModel>();


        //initialize new instances
        public IndianStateCensus(string state, string population, string area, string density)
        {
            this.State = state;
            this.Population = population;
            this.Area = area;
            this.Density = density;
        }

        public IndianStateCensus()
        {
        }

        public override Dictionary<string, StateCensusModel> LoadCsv(string path)
        {

            foreach (string line in File.ReadLines(path).Skip(1))
            {

                string[] column = line.Split(",");
                census = new IndianStateCensus(column[0], column[1], column[2], column[3]);
                dataMap.Add(column[0], census);
            }
            return dataMap;
        }
    }
}
