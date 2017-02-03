using System;
using System.Windows.Forms;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;
using LP2Forms.Repositories;

namespace LP2Forms
{
    public partial class Gebieden : Form
    {
        private IGebiedenRepository _repo;

        public Gebieden()
        {

            InitializeComponent();
            _repo = new GebiedenRepository(new GebiedenSQLContext(new DatabaseConnector()));
            cbGebieden.DataSource = _repo.GetAll();

        }

        private void Gebieden_Activated(object sender, EventArgs e)
        {
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            Hide();
            new Veldkaart((Gebied)cbGebieden.SelectedItem).Show();
        }

        private void btnBerekenBroedparen_Click(object sender, EventArgs e)
        {
            new Teller().ShowDialog();
        }
    }
}
