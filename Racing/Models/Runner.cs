using Racing.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Racing.Models
{
    public class Runner
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlAttribute("TabNo")]
        public int TabNo { get; set; }

        [XmlAttribute("Barrier")]
        public int Barrier { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Price")]
        public decimal Price { get; set; }

        [XmlAttribute("Jockey")]
        public string Jockey { get; set; }

        [XmlAttribute("Trainer")]
        public string Trainer { get; set; }
    }
}
