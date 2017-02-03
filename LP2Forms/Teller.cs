using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using LP2Forms.Contexts;
using LP2Forms.Repositories;

namespace LP2Forms
{
    public partial class Teller : Form
    {
        public Teller()
        {
            InitializeComponent();
            var repo = new DierRepository(new DierSQLContext(new DatabaseConnector()));
            try
            {
                repo.BerekenBroedparen();
                lbTeller.DataSource = repo.GetAll().Select(x => x.Naam + " - " + x.BroedParen).ToList();
            }
            catch (InvalidOperationException)
            {
                lbTeller.Items.Add("There has been a fatal error. Please contact an admin");
            }
            catch (SqlException)
            {
                lbTeller.Items.Add("There has been an sql exception. Please contact an admin");
            }
        }
    }
}
