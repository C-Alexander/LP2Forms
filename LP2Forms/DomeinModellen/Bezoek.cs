using System;
using System.Collections.Generic;

namespace LP2Forms.DomeinModellen
{
    public class Bezoek
    {
        public int BezoekNummer { get; set; }
        public DateTime BeginBezoek { get; set; }
        public DateTime EindBezoek { get; set; }
        public List<Waarneming> Waarnemingen { get; set; } = new List<Waarneming>();
    }
}