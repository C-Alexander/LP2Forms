using System;
using LP2Forms.Models;

namespace LP2Forms.DomeinModellen
{
    public class Dier
    {
        public string Naam { get; set; }
        public string Afkorting { get; set; }
        public DateTime BroedPeriodeStart { get; set; }
        public DateTime BroedPeriodeEind { get; set; }
        public int BroedParen { get; set; }
        public int Id { get; set; }
        public DierSoort DierSoort { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Naam + " " + Afkorting;
        }
    }
}