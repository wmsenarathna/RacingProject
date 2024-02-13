using Microsoft.VisualStudio.TestTools.UnitTesting;
using Racing.Helper;
using Racing.Models.HarnessRaces;
using Racing.Models.GreyHoundsRaces;
using Racing.Models.HorseRaces;
using Racing.Enums;
using Newtonsoft.Json.Linq;
using System;

namespace RacingTest
{
    [TestClass]
    public class RacingTest
    {
        [TestMethod]
        public void Is_Data_Available_HorseRaces_Service()
        {
            bool result = true;

            var servicePath = ServiceHelper.GetServicePath(GameTypeEnum.HorseRaces);
            var xmlSerializerDeserializer = new XmlSerializerDeserializer<HorseRaces>();
            var races = xmlSerializerDeserializer.DeserilazeFromXml(servicePath);

            if (races == null 
                || races.RaceUpdate == null 
                || races.RaceUpdate.Count == 0)
            {
                result = false;
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Validate_Internal_Data_Format_HorseRaces_Service()
        {
            bool result = true;

            var servicePath = ServiceHelper.GetServicePath(GameTypeEnum.HorseRaces);
            var xmlSerializerDeserializer = new XmlSerializerDeserializer<HorseRaces>();
            var races = xmlSerializerDeserializer.DeserilazeFromXml(servicePath);

            var jsonSerializerDeserializer = new JsonSerializerDeserializer<HorseRaces>();
            var racesData = jsonSerializerDeserializer.SerializeToJson(races);

            try
            {
                JObject.Parse(racesData);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            Assert.IsTrue(result);
        }
    }
}
