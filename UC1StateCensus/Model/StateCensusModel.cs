using System;
using System.Collections.Generic;
using System.Text;

namespace UC1StateCensus
{
   public abstract class StateCensusModel : ILoadCsv
    {
        public string State;
        public string Population;
        public string Area;
        public string Density;
        public string SerialNum;
        public string StateName;
        public string Tin;
        public string StateCode;
        public string totalArea;
        public string waterArea;
        public string landArea;

        public abstract Dictionary<string, StateCensusModel> LoadCsv(string filePath);
    }
}
