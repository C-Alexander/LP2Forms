using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using LP2Forms.DomeinModellen;
using LP2Forms.Models;

namespace LP2Forms.Contexts
{
    internal class DierSQLContext : IDierSQLContext
    {
        private DatabaseConnector _databaseConnector;

        public DierSQLContext(DatabaseConnector databaseConnector)
        {
            this._databaseConnector = databaseConnector;
        }

        public ICollection<Dier> GetAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [Dier] JOIN [Diersoort] ON [Dier].DiersoortId = [Diersoort].Id";

            try
            {
                var dieren = new List<Dier>();
                DbDataReader reader;
                using (reader = _databaseConnector.RunCommand(cmd))
                {
                    while (reader != null && reader.Read())
                    {
                        var dier = new Dier()
                        {
                            Id = reader.GetInt32(0),
                            Naam = reader.GetString(1),
                            Afkorting = reader.GetString(2),
                            BroedPeriodeStart = reader.GetDateTime(3),
                            BroedPeriodeEind = reader.GetDateTime(4),
                            BroedParen = reader.GetInt32(6),
                            DierSoort = new DierSoort()
                            {
                                Id = reader.GetInt32(8),
                                Naam = reader.GetString(9)
                            }
                        };
                        dieren.Add(dier);
                    }
                }
                return dieren;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

        public void BerekenBroedparen()
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "BerekenAlleBroedParen"
            };
            cmd.CommandType = CommandType.StoredProcedure;
            _databaseConnector.RunCommandNonQuery(cmd);
        }
    }
}