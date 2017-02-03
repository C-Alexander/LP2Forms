using System;
using System.Windows.Forms;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;
using LP2Forms.Repositories;

namespace LP2Forms
{
    public partial class NieuweWaarneming : Form
    {
        private IDierRepository _dierRepo;
        private WaarnemingsSoortRepository _wSoortRepo;

        public NieuweWaarneming()
        {
            InitializeComponent();
            _dierRepo = new DierRepository(new DierSQLContext(new DatabaseConnector()));
            _wSoortRepo = new WaarnemingsSoortRepository(new WaarnemingsSoortSQLContext(new DatabaseConnector()));
        }

        public Waarneming Waarneming { get; set; } = new Waarneming();

        private void NieuweWaarneming_Load(object sender, EventArgs e)
        {
            cbDier.DataSource = _dierRepo.GetAll();
            cbWaarnemingsSoort.DataSource = _wSoortRepo.GetAll();
            dtpWaarnemingsTijd.Value = DateTime.Now;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Waarneming.Dier = (Dier) cbDier.SelectedItem;
            Waarneming.WaarnemingsSoort = (WaarnemingsSoort) cbWaarnemingsSoort.SelectedItem;
            Waarneming.WaarnemingsTijd = dtpWaarnemingsTijd.Value;
            Hide();
        }

        private void cbDier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //only the right animal here!
        }
    }
}
