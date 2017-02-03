namespace LP2Forms.DomeinModellen
{
    public struct WaarnemingsSoort
    {
        public readonly int Id;
        public readonly string Naam;
        public readonly string Asset;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public WaarnemingsSoort(int id, string naam, string asset)
        {
            Id = id;
            Naam = naam;
            Asset = asset;
        }

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A <see cref="T:System.String" /> containing a fully qualified type name.</returns>
        public override string ToString()
        {
            return Naam;
        }
    }
}