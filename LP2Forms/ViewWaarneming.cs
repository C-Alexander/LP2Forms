using System;
using System.Windows.Forms;
using LP2Forms.DomeinModellen;

namespace LP2Forms
{
    public partial class ViewWaarneming : Form
    {
        public ViewWaarneming(Waarneming w)
        {
            InitializeComponent();
            lblDier.Text = w.Dier.Naam;
            lblSoort.Text = w.WaarnemingsSoort.Naam;
            dtpViewW.Value = w.WaarnemingsTijd;
        }

        private void ViewWaarneming_Load(object sender, EventArgs e)
        {

        }

/*
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var repo = new GebiedenRepository(new GebiedenSQLContext(new DatabaseConnector()));
        }
*/
    }
}
