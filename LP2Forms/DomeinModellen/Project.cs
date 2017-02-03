using System.Collections.Generic;
using System.Xml.Serialization;

namespace LP2Forms.DomeinModellen
{
    public class Project
    {
        [XmlIgnore]
        public Gebruiker Eigenaar { get; set; }
        public string Naam { get; set; }
        [XmlIgnore]
        public Gebied Gebied { get; set; }
        public List<Bezoek> Bezoeken { get; set; } = new List<Bezoek>();
    }
}