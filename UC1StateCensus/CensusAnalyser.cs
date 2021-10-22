using System;
using System.Collections.Generic;
using System.Text;

namespace UC1StateCensus
{
        public enum FileType
        {
            STATE_CENSUS
        }

        public class CensusAnalyser
        {
            public Dictionary<string, StateCensusModel> LoadCsvFile(FileType type, string filePath, string dataheaders)
            {
                return new CensusAdaptor().LoadCsv(type, filePath, dataheaders);
            }
        }
    }
}
