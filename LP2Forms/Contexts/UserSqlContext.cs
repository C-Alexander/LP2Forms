using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using LP2Forms.DomeinModellen;
using LP2Forms.Exceptions;

namespace LP2Forms.Contexts
{
    public class UserSQLContext : IUserContext
    {
        private IDatabaseConnector DatabaseConnector { get; set; }
        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public UserSQLContext(IDatabaseConnector dbConnector)
        {
            DatabaseConnector = dbConnector;
        }

        public void Registreer(Gebruiker gebruiker)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Registreer" //seriously, FUCK dutch programming
            };
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Gebruikersnaam", gebruiker.Gebruikersnaam);
            cmd.Parameters.AddWithValue("@Naam", gebruiker.Naam);
            cmd.Parameters.AddWithValue("@Wachtwoord", gebruiker.Wachtwoord);
            try
            {
                DatabaseConnector.RunCommandNonQuery(cmd);
            }
            catch (SqlException e)
            {
                if (e.State == 1)
                {
                    throw new UserNameTakenException();
                }
                else
                {
                    Console.WriteLine(e);
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
        }

        public void Delete(Gebruiker gebruiker)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "DELETE FROM [Gebruiker]" +
                              " WHERE [Gebruiker].Id = @Id"
            };
            cmd.Parameters.AddWithValue("@Id", gebruiker.Id);
            DatabaseConnector.RunCommandNonQuery(cmd);
        }

        public void Update(Gebruiker gebruiker)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText =
                    "UPDATE [Gebruiker] SET Wachtwoord=@Wachtwoord, Naam=@Naam" +
                    " WHERE [Gebruiker].Id = @Id"
            };
            cmd.Parameters.AddWithValue("@Naam", gebruiker.Naam);
            cmd.Parameters.AddWithValue("@Wachtwoord", gebruiker.Wachtwoord);
            cmd.Parameters.AddWithValue("@Id", gebruiker.Id);
            DatabaseConnector.RunCommandNonQuery(cmd);
        }

        public ICollection<Gebruiker> Read()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [Gebruiker]";
            DbDataReader reader = null;

            try
            {
                ICollection<Gebruiker> gebruikerList = new List<Gebruiker>();
                using (reader = DatabaseConnector.RunCommand(cmd))
                {
                    while (reader != null && reader.Read())
                    {
                        Gebruiker gebruiker = new Gebruiker
                        {
                            Id = reader.GetInt32(0),
                            Gebruikersnaam = reader.GetString(1),
                            Naam = reader.GetString(2),
                            Wachtwoord = reader.GetString(3)
                        };
                        gebruikerList.Add(gebruiker);
                    }
                }
                return gebruikerList;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

        /// <summary>
        /// Logs in the user
        /// </summary>
        /// <param name="gebruiker"></param>
        /// <returns>The ID of the logged in user, or an exception</returns>
        public Gebruiker Login(Gebruiker gebruiker)
        {
            return Login(gebruiker.Gebruikersnaam, gebruiker.Wachtwoord);
        }

        /// <summary>
        /// Logs in the user
        /// </summary>
        /// <param name="gebruikersnaam"></param>
        /// <param name="wachtwoord"></param>
        /// <returns>The ID of the logged in user, or an exception</returns>
        public Gebruiker Login(string gebruikersnaam, string wachtwoord)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Login"
            };
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Gebruikersnaam", gebruikersnaam);
            cmd.Parameters.AddWithValue("@Wachtwoord", wachtwoord);
            SqlParameter id = cmd.Parameters.Add("@GebruikerId", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;
            SqlParameter naam = cmd.Parameters.Add("@Naam", SqlDbType.NVarChar, 64);
            naam.Direction = ParameterDirection.Output;
            try
            {

                DbDataReader reader = DatabaseConnector.RunCommand(cmd);
                reader.Read();

                return new Gebruiker()
                {
                    Id = (int) cmd.Parameters["@GebruikerId"].Value,
                    Gebruikersnaam = gebruikersnaam,
                    Wachtwoord = wachtwoord,
                    Naam = (string) cmd.Parameters["@Naam"].Value
                };
            }
            catch (SqlException e)
            {
                if (e.State == 1)
                {
                    throw new UsernameNotFoundException();
                } else if (e.State == 2)
                {
                    throw new WrongPasswordException();
                }
                else Console.WriteLine(e);
                return null; //if we reached this, something went EXTREMELY wrong.
            }
        }

        public bool GebruikersnaamBestaat(string gebruikersnaam)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT COUNT(*) FROM [Gebruiker] WHERE [Gebruiker].Gebruikersnaam = @Gebruikersnaam"
            };
            cmd.Parameters.AddWithValue("@Gebruikersnaam", gebruikersnaam);
            var count =  DatabaseConnector.RunScalar(cmd);
            if (count != null && ((int)count) > 0)
            {
                return true;
            } else return false;
        }
    }
}
