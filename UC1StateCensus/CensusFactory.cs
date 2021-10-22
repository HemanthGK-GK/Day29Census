using System;
using System.Collections.Generic;
using System.Text;

namespace UC1StateCensus
{
    class CensusFactory
    {
        public Dictionary<FileType, StateCensusModel> fileInstanceMap = new Dictionary<FileType, StateCensusModel>();

        internal StateCensusModel GetObject(FileType type)
        {
            if (fileInstanceMap.ContainsKey(type))
                return fileInstanceMap[type];
            if (type == FileType.STATE_CENSUS)
                return new IndianStateCensus();
            return null;
        }
    }
}
