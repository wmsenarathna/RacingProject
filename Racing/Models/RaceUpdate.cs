using Racing.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Racing.Models
{
    public class RaceUpdate
    {
        [XmlElement("MeetingID")]
        public int MeetingId { get; set; }

        [XmlElement("RaceId")]
        public int RaceId { get; set; }

        [XmlElement("RaceLocation")]
        public string RaceLocation { get; set; }

        [XmlElement("RaceDistance")]
        public int RaceDistance { get; set; }

        [XmlElement("RaceNo")]
        public int RaceNo { get; set; }

        [XmlElement("RaceType")]
        public RaceTypeEnum RaceType { get; set; }

        [XmlElement("RaceInfo")]
        public string RaceInfo { get; set; }

        [XmlElement("TrackCondition")]
        public TrackConditionEnum TrackCondition { get; set; }

        [XmlElement("Source")]
        public string Source { get; set; }

        [XmlElement("PriceType")]
        public PriceTypeEnum PriceType { get; set; }

        [XmlElement("PoolSize")]
        public int PoolSize { get; set; }

        [XmlElement("StartTime")]
        public string StartTime { get; set; }

        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        [XmlElement("Runners")]
        public Runners Runners { get; set; }
    }
}
