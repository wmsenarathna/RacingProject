using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.Models.HarnessRaces;

namespace Racing.DataAccess.Interfaces
{
    interface IHarnessRacesDal
    {
        HarnessRaces GetRaceInformation(int raceId);
        void CreateRaceInformation(HarnessRaces data, string json);
        void UpdateRaceInformation(HarnessRaces data, string json);
    }
}
