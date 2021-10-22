using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UC1StateCensus
{
    class CensusAdaptor
    {
        public Dictionary<string, StateCensusModel> LoadCsv(FileType type, string path, string dataheaders)
        {

            if (!File.Exists(path))
                throw new CustomException("File doesnt exist", CustomException.ExceptionType.FILE_NOT_FOUND);

            using (StreamReader stream = new StreamReader(path))
            {
                if (stream.ReadLine() != dataheaders)
                    throw new CustomException("Data headers doesn't match", CustomException.ExceptionType.HEADER_NOT_MATCH);

            }

            var census = new CensusFactory().GetObject(type);

            return census.LoadCsv(path);
        }

    }
}
