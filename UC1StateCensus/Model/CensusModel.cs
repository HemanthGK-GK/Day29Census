using System;
using System.Collections.Generic;
using System.Text;

namespace UC1StateCensus
{
    class CensusModel
    {
        public string SerialNum;
        public string StateName;
        public string Tin;
        public string StateCode;

        public CensusModel(string serialNum, string stateName, string tin, string stateCode)
        {
            SerialNum = serialNum;
            StateName = stateName;
            Tin = tin;
            StateCode = stateCode;
        }
    }
}
