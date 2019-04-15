using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp
{
    class StationList
    {
        List<Station> Stations = new List<Station>()
    
        {
            new Station { ID = 1, StationName ="A1"},
            new Station { ID = 2, StationName ="A2"},
            new Station { ID = 3, StationName ="A3"},
            new Station { ID = 4, StationName ="A4"},
            new Station { ID = 5, StationName ="A5"},
            new Station { ID = 6, StationName ="A6"},
            new Station { ID = 7, StationName ="A7"},
            new Station { ID = 8, StationName ="A8"},
            new Station { ID = 9, StationName ="A9"},
            new Station { ID = 10, StationName ="A10"}

        };

        public Station GetStationByStationName(string stationName)
        {
            return Stations.FirstOrDefault(s => s.StationName == stationName);

        }

        public int CalculateNoofStations(string entryStation, string existSt)
        {
            entryStation =  entryStation.Replace("A","");
            existSt = existSt.Replace("A", "");
            return Math.Abs(Convert.ToInt32(existSt) - Convert.ToInt32(entryStation));

        }
        
    }
}
