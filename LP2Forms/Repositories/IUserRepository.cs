using System.Collections.Generic;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Repositories
{
    public interface IUserRepository
    {
        void Registreer(Gebruiker gebruiker);
        void Delete(Gebruiker gebruiker);
        void Update(Gebruiker gebruiker);
        ICollection<Gebruiker> Read();
        void Login(Gebruiker gebruiker);
        void Login(string gebruikersnaam, string wachtwoord);
        bool GebruikersnaamBestaat(string gebruikersnaam);
    }
}
