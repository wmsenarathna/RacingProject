using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.DataAccess.Interfaces;
using Racing.Models.HorseRaces;

namespace Racing.DataAccess.Services
{
    public class HorseRacesDal : IHorseRacesDal
    {
        public HorseRaces GetRaceInformation(int raceId)
        {
            //ToDo
            return null;
        }

        public void CreateRaceInformation(HorseRaces data, string json)
        {
            //ToDo
        }

        public void UpdateRaceInformation(HorseRaces data, string json)
        {
            //ToDo
        }
    }
}
