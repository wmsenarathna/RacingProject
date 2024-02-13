using Racing.Enums;
using Racing.Models.GreyHoundsRaces;
using Racing.Models.HarnessRaces;
using Racing.Models.HorseRaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Helper
{
    public class ServiceHelper
    {
        public static string GetServicePath(GameTypeEnum gameType)
        {
            string basePath = "D:\\Racing Project\\Racing\\Services\\";

            switch (gameType)
            {
                case GameTypeEnum.HorseRaces:
                    return Path.Combine(basePath, "HorseRaces.xml");
                case GameTypeEnum.GreyHoundsRaces:
                    return Path.Combine(basePath, "GreyHoundsRaces.xml");
                case GameTypeEnum.HarnessRaces:
                    return Path.Combine(basePath, "HarnessRaces.xml");
                default:
                    return string.Empty;
            }
        }
    }
}
