using System.Collections.Generic;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Contexts
{
    public interface IUserContext
    {
        void Registreer(Gebruiker gebruiker);
        void Delete(Gebruiker gebruiker);
        void Update(Gebruiker gebruiker);
        ICollection<Gebruiker> Read();
        Gebruiker Login(Gebruiker gebruiker);
        Gebruiker Login(string gebruikersnaam, string wachtwoord);
        bool GebruikersnaamBestaat(string gebruikersnaam);
    }
}
