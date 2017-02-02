using System.Data.Common;

namespace LP2Forms
{
    public interface IDatabaseConnector
    {
        DbConnection Connection { get; set; }

        DbDataReader RunCommand(DbCommand command);
        void RunCommandNonQuery(DbCommand command);
        object RunScalar(DbCommand cmd);
    }
}