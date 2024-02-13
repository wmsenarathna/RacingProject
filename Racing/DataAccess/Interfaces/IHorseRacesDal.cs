using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.Models.HorseRaces;

namespace Racing.DataAccess.Interfaces
{
    interface IHorseRacesDal
    {
        HorseRaces GetRaceInformation(int raceId);
        void CreateRaceInformation(HorseRaces data, string json);
        void UpdateRaceInformation(HorseRaces data, string json);
    }
}
