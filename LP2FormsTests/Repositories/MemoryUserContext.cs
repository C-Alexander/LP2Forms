using System.Collections.Generic;
using System.Linq;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;
using LP2Forms.Exceptions;

namespace LP2FormsTests.Repositories
{
    internal class MemoryUserContext : IUserContext
    {
        private List<Gebruiker> _gebruikersList = new List<Gebruiker>();
        public void Registreer(Gebruiker gebruiker)
        {
            _gebruikersList.Add(gebruiker);
        }

        public void Delete(Gebruiker gebruiker)
        {
            _gebruikersList.Remove(gebruiker);
        }

        public void Update(Gebruiker gebruiker)
        {
            var gebruikerOmTeVeranderen = _gebruikersList.First(g => g.Id == gebruiker.Id);
            gebruikerOmTeVeranderen = gebruiker;
        }

        public ICollection<Gebruiker> Read()
        {
            return _gebruikersList;
        }

        public Gebruiker Login(Gebruiker gebruiker)
        {
            if (!_gebruikersList.Any(g => g.Gebruikersnaam == gebruiker.Gebruikersnaam))
            {
                throw new UsernameNotFoundException();
            } else if (
                !_gebruikersList.Any(
                    g => g.Gebruikersnaam == gebruiker.Gebruikersnaam && g.Wachtwoord == gebruiker.Wachtwoord))
            {
                throw new WrongPasswordException();
            }
            return gebruiker;
        }

        public Gebruiker Login(string gebruikersnaam, string wachtwoord)
        {
            return Login(new Gebruiker()
            {
                Gebruikersnaam = gebruikersnaam,
                Wachtwoord = wachtwoord
            });
        }

        public bool GebruikersnaamBestaat(string gebruikersnaam)
        {
            if (!_gebruikersList.Any(g => g.Gebruikersnaam == gebruikersnaam))
            {
                return false;
            }
            return true;
        }
    }
}