using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.DataAccess.Interfaces;
using Racing.Models.HarnessRaces;

namespace Racing.DataAccess.Services
{
    public class HarnessRacesDal : IHarnessRacesDal
    {
        public HarnessRaces GetRaceInformation(int raceId)
        {
            //ToDo
            return null;
        }

        public void CreateRaceInformation(HarnessRaces data, string json)
        {
            //ToDo
        }

        public void UpdateRaceInformation(HarnessRaces data, string json)
        {
            //ToDo
        }
    }
}
