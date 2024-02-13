using Racing.BusinessLogic.Interfaces;
using Racing.Enums;
using Racing.Helper;
using Racing.Models;
using Racing.Models.HarnessRaces;
using Racing.Models.HorseRaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.DataAccess.Services;

namespace Racing.BusinessLogic.Services
{
    public class HorseRacesService : IHorseRaces
    {
        // Here right thing is apply DI injection
        public HorseRacesService()
        {

        }

        public string GetRaceInformation()
        {
            try
            {
                var servicePath = ServiceHelper.GetServicePath(GameTypeEnum.HorseRaces);

                var xmlSerializerDeserializer = new XmlSerializerDeserializer<HorseRaces>();
                var races = xmlSerializerDeserializer.DeserilazeFromXml(servicePath);

                var jsonSerializerDeserializer = new JsonSerializerDeserializer<HorseRaces>();
                var racesData = jsonSerializerDeserializer.SerializeToJson(races);

                var horseRacesDal = new HorseRacesDal(); // Here right thing is apply DI injection
                foreach (var item in races.RaceUpdate)
                {
                    var race = horseRacesDal.GetRaceInformation(item.RaceId);
                    // Here save data into database 
                    if (race == null)
                    {
                        horseRacesDal.CreateRaceInformation(races, racesData);
                    }
                    else
                    {
                        horseRacesDal.UpdateRaceInformation(races, racesData);
                    }
                }

                return racesData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return string.Empty;
        }
    }
}
