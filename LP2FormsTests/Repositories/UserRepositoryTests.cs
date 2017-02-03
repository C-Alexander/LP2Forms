using System;
using System.Linq;
using LP2Forms.DomeinModellen;
using LP2Forms.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP2FormsTests.Repositories
{
    [TestClass()]
    public class UserRepositoryTests
    {
        private IUserRepository _repo;
        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public UserRepositoryTests()
        {
            _repo = UserRepositoryFactory();
        }

        [TestMethod()]
        public void RegistreerTest()
        {
            _repo.Registreer(new Gebruiker()
            {
                Id = 0,
                Gebruikersnaam = "test",
                Wachtwoord = "bob"
            });
            _repo.Registreer(new Gebruiker()
            {
                Id = 1,
                Gebruikersnaam = "trala",
                Wachtwoord = "two"
            });
            _repo.Registreer(new Gebruiker()
            {
                Id = 2,
                Gebruikersnaam = "trala2",
                Wachtwoord = "two2"
            });
        }

        [TestMethod()]
        public void DeleteTest()
        {
            _repo.Delete(new Gebruiker()
            {
                Id = 0,
                Gebruikersnaam = "test",
                Wachtwoord = "bob"
            });
            if (_repo.Read().Any(u => u.Id == 0))
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void UpdateTest()
        {
            _repo.Update(new Gebruiker()
            {
                Id = 1,
                Gebruikersnaam = "tralala",
                Wachtwoord = "two"
            });
            if (_repo.Read().Any(g => g.Gebruikersnaam == "trala"))
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ReadTest()
        {
            _repo.Read();
        }

        [TestMethod()]
        public void LoginTest()
        {
            try
            {
                _repo.Login("test", "test");
                Assert.Fail();
            }
            catch (Exception)
            {
                // ignored
            }

            try
            {
                _repo.Login("trala2", "two2");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GebruikersnaamBestaatTest()
        {
            if (_repo.GebruikersnaamBestaat("lolol"))
            {
                Assert.Fail();
            }
        }

        public UserRepository UserRepositoryFactory()
        {
            return new UserRepository(new MemoryUserContext());
        }
    }
}