using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Racing.Models
{
    public class Runners
    {
        [XmlElement("Runner")]
        public List<Runner> Runner { get; set; }
    }
}
