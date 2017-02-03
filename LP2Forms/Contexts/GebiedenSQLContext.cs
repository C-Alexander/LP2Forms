using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Contexts
{
    internal class GebiedenSQLContext : IGebiedenSQLContext
    {
        private DatabaseConnector _databaseConnector;

        public GebiedenSQLContext(DatabaseConnector databaseConnector)
        {
            this._databaseConnector = databaseConnector;
        }

        public ICollection<Gebied> GetAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [Gebied] JOIN [Project] ON [Project].GebiedId = [Gebied].Id";
            DbDataReader reader;

            try
            {
                var gebieden = new List<Gebied>();
                using (reader = _databaseConnector.RunCommand(cmd))
                {
                    while (reader != null && reader.Read())
                    {
                        var gebied = new Gebied()
                        {
                            Id = reader.GetInt32(0),
                            Naam = reader.GetString(1),
                            ActiefProject = new Project()
                            {
                                Eigenaar = Session.Gebruiker,
                                Naam = "Default Project"
                            }
                        };
                        gebied.ActiefProject.Gebied = gebied;
                        if (!reader.IsDBNull(2))
                        {
                            gebied.Asset = reader.GetString(2);
                        }
                        gebieden.Add(gebied);
                    }
                }
                return gebieden;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
    }
}