using Racing.BusinessLogic.Interfaces;
using Racing.Enums;
using Racing.Helper;
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
    public class HarnessRacesService : IHarnessRaces
    {
        // Here right thing is apply DI injection
        public HarnessRacesService()
        {

        }

        public string GetRaceInformation()
        {
            try
            {
                var servicePath = ServiceHelper.GetServicePath(GameTypeEnum.HarnessRaces);

                var xmlSerializerDeserializer = new XmlSerializerDeserializer<HarnessRaces>();
                var races = xmlSerializerDeserializer.DeserilazeFromXml(servicePath);

                var jsonSerializerDeserializer = new JsonSerializerDeserializer<HarnessRaces>();
                var racesData = jsonSerializerDeserializer.SerializeToJson(races);

                var harnessRacesDal = new HarnessRacesDal(); // Here right thing is apply DI injection
                foreach (var item in races.RaceUpdate)
                {
                    var race = harnessRacesDal.GetRaceInformation(item.RaceId);
                    // Here save data into database 
                    if (race == null)
                    {
                        harnessRacesDal.CreateRaceInformation(races, racesData);
                    }
                    else
                    {
                        harnessRacesDal.UpdateRaceInformation(races, racesData);
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
