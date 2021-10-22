using System;
using System.Collections.Generic;
using System.Text;

namespace UC1StateCensus
{
    class StateModel
    {
        public string State;
        public string Population;
        public string Area;
        public string Density;

        public StateModel(string state, string population, string area, string density)
        {
            State = state;
            Population = population;
            Area = area;
            Density = density;
        }
    }
}
