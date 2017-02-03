namespace LP2Forms.DomeinModellen
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Naam { get; set; }
        public string Wachtwoord { get; set; }
        public Project Project { get; set; }
    }
}
