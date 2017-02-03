using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Contexts
{
    internal class WaarnemingsSoortSQLContext
    {
        private DatabaseConnector _databaseConnector;

        public WaarnemingsSoortSQLContext(DatabaseConnector databaseConnector)
        {
            this._databaseConnector = databaseConnector;
        }

        public ICollection<WaarnemingsSoort> GetAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [WaarnemingsSoort]";
            DbDataReader reader;

            try
            {
                var waarnemingsSoorten = new List<WaarnemingsSoort>();
                using (reader = _databaseConnector.RunCommand(cmd))
                {
                    while (reader != null && reader.Read())
                    {
                        var waarnemingsSoort = new WaarnemingsSoort(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        waarnemingsSoorten.Add(waarnemingsSoort);
                    }
                }
                return waarnemingsSoorten;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
    }
}