using System.Collections.Generic;

namespace UC1StateCensus
{
    public interface ILoadCsv
    {
        Dictionary<string, StateCensusModel> LoadCsv(string filePath);
    }
}