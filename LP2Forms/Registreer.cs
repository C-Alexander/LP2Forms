using System;
using System.Windows.Forms;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;
using LP2Forms.Exceptions;
using LP2Forms.Repositories;

namespace LP2Forms
{
    public partial class Registreer : Form
    {
        private IUserRepository _repo;

        public Registreer()
        {
            _repo = new UserRepository(new UserSQLContext(new DatabaseConnector()));
            InitializeComponent();
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            lblErrors.Text = "";
            if (string.IsNullOrWhiteSpace(tbGebruikersnaam.Text))
                lblErrors.Text += "Vul alstublieft een gebruikersnaam in.\n";
            if (string.IsNullOrWhiteSpace(tbNaam.Text))
                lblErrors.Text += "Vul alstublieft een naam in.\n";
            if (string.IsNullOrWhiteSpace(tbWachtwoord.Text))
                lblErrors.Text += "Vul alstublieft een wachtwoord in.\n";
            if (string.IsNullOrWhiteSpace(tbHerhaalWachtwoord.Text))
                lblErrors.Text += "Herhaal alstublieft uw gekozen wachtwoord.\n";
            if (!tbWachtwoord.Text.Equals(tbHerhaalWachtwoord.Text))
                lblErrors.Text += "Uw wachtwoord en de herhaling hiervan zijn niet hetzelfde.\n";
            if (string.IsNullOrWhiteSpace(lblErrors.Text))
            {
                try
                {
                    _repo.Registreer(new Gebruiker()
                    {
                        Gebruikersnaam = tbGebruikersnaam.Text,
                        Naam = tbNaam.Text,
                        Wachtwoord = tbWachtwoord.Text
                    });
                }
                catch (UserNameTakenException)
                {
                    lblErrors.Text += "Deze gebruikersnaam is al door een ander gekozen";
                }
                if (Session.IsLoggedIn())
                Close();
                if (string.IsNullOrWhiteSpace(lblErrors.Text) && !Session.IsLoggedIn())
                    lblErrors.Text += "Oops, er is iets fout gegaan.\n" +
                                      "Neem alstublieft contact op met uw beheerder.\n" +
                                      "Onze excuses voor het ongemak.";
            }
        }
    }
}
