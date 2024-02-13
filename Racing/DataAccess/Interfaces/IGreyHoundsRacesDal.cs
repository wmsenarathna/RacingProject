using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.Models.GreyHoundsRaces;

namespace Racing.DataAccess.Interfaces
{
    interface IGreyHoundsRacesDal
    {
        GreyHoundsRaces GetRaceInformation(int raceId);
        void CreateRaceInformation(GreyHoundsRaces data, string json);
        void UpdateRaceInformation(GreyHoundsRaces data, string json);
    }
}
