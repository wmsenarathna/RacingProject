using Racing.BusinessLogic.Interfaces;
using Racing.Enums;
using Racing.Helper;
using Racing.Models.GreyHoundsRaces;
using Racing.Models.HorseRaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.DataAccess.Services;

namespace Racing.BusinessLogic.Services
{
    public class GreyHoundsRacesService : IGreyHoundsRaces
    {
        // Here right thing is apply DI injection
        public GreyHoundsRacesService()
        {

        }

        public string GetRaceInformation()
        {
            try
            {
                var servicePath = ServiceHelper.GetServicePath(GameTypeEnum.GreyHoundsRaces);

                var xmlSerializerDeserializer = new XmlSerializerDeserializer<GreyHoundsRaces>();
                var races = xmlSerializerDeserializer.DeserilazeFromXml(servicePath);

                var jsonSerializerDeserializer = new JsonSerializerDeserializer<GreyHoundsRaces>();
                var racesData = jsonSerializerDeserializer.SerializeToJson(races);

                var greyHoundsRacesDal = new GreyHoundsRacesDal(); // Here right thing is apply DI injection
                foreach (var item in races.RaceUpdate)
                {
                    var race = greyHoundsRacesDal.GetRaceInformation(item.RaceId);
                    // Here save data into database 
                    if (race == null)
                    {
                        greyHoundsRacesDal.CreateRaceInformation(races, racesData);
                    }
                    else
                    {
                        greyHoundsRacesDal.UpdateRaceInformation(races, racesData);
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
