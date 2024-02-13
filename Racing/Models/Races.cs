using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Racing.Models
{
    public class Races
    {
        [XmlElement("RaceUpdate")]
        public List<RaceUpdate> RaceUpdate { get; set; }
    }
}
