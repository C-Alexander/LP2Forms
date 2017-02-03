using System.Collections.Generic;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IUserContext _context;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public UserRepository(IUserContext context)
        {
            _context = context;
        }

        public void Registreer(Gebruiker gebruiker)
        {
            _context.Registreer(gebruiker);
            Login(gebruiker);
        }

        public void Delete(Gebruiker gebruiker)
        {
            _context.Delete(gebruiker);
        }

        public void Update(Gebruiker gebruiker)
        {
            _context.Update(gebruiker);
        }

        public ICollection<Gebruiker> Read()
        {
            return _context.Read();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gebruiker"></param>
        /// <returns>Userid of logged in user or fitting exception</returns>
        public void Login(Gebruiker gebruiker)
        {
            Login(gebruiker.Gebruikersnaam, gebruiker.Wachtwoord);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gebruikersnaam"></param>
        /// <param name="wachtwoord"></param>
        /// <returns>Userid of logged in user or fitting exception</returns>
        public void Login(string gebruikersnaam, string wachtwoord)
        {
            var gebruiker = _context.Login(gebruikersnaam, wachtwoord);
            if (gebruiker != null)
            {
                Session.IsLoggedIn(true, gebruiker);
            }
        }

        public bool GebruikersnaamBestaat(string gebruikersnaam)
        {
            return _context.GebruikersnaamBestaat(gebruikersnaam);
        }
    }
}
