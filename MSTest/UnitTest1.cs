using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        public static string indianStateCensusHeaders = "State,Population,Area,Density";
        public static string indianStateCodeHeaders = "SerialNumber,State Name,Tin,StateCode";
        public static string indianStateCensusFilePath = @"C:\Users\91807\Desktop\Batch67\UC1StateCensus\CSV\Census.csv";
        public static string indianStateCodeFilePath = @"C:\Users\91807\Desktop\Batch67\UC1StateCensus\CSV\State.csv"


        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [TestMethod]
        public void GivenIndianCensusDataFile()
        {
            totalRecord = censusAnalyser.LoadCsvFile(IndiaCensus.FileType.STATE_CENSUS, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }

        [TestMethod]
        public void GivenIndianStateCodeDataFile()
        {
            totalRecord = censusAnalyser.LoadCsvFile(IndiaCensus.FileType.STATE_CODE, indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(37, totalRecord.Count);
        }


    }
    }
}
