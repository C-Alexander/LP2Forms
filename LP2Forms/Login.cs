using System;
using System.Windows.Forms;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;
using LP2Forms.Exceptions;
using LP2Forms.Repositories;

namespace LP2Forms
{
    public partial class Login : Form
    {
        private IUserRepository _repo;
        public Login()
        {
            if (Session.IsLoggedIn())
            {
                Hide();
                new Gebieden().Show();
            }
            InitializeComponent();
            _repo = new UserRepository(new UserSQLContext(new DatabaseConnector()));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrors.Text = "";
            if (string.IsNullOrWhiteSpace(tbGebruikersnaam.Text))
                lblErrors.Text += "Voer alstublieft een gebruikersnaam in.\n";
            if (string.IsNullOrWhiteSpace(TbWachtwoord.Text))
                lblErrors.Text += "Voer alstublieft een wachtwoord in.\n";
            if (string.IsNullOrWhiteSpace(lblErrors.Text))
            {
                try
                {
                    _repo.Login(tbGebruikersnaam.Text, TbWachtwoord.Text);
                    if (Session.IsLoggedIn())
                    {
                        Hide();
                        new Gebieden().Show();
                    }
                    else
                    {
                        lblErrors.Text += "Oops, er is iets mis gegaan.\n" +
                                          "Neem contact op met de beheerder.\n";
                    }
                }
                catch (UsernameNotFoundException)
                {
                    lblErrors.Text += "Gebruikersnaam is niet gevonden.\n";
                }
                catch (WrongPasswordException)
                {
                    lblErrors.Text += "Wachtwoord is niet correct.\n";
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Fatale fout, staat uw VPN aan en heeft u een internet connectie?");
                }
            }
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            var registreer = new Registreer();
            registreer.ShowDialog();
            if (Session.IsLoggedIn())
            {
                Hide();
                new Gebieden().Show();
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Veldkaart(new Gebied() {
                Naam = "Offline Gebied",
            ActiefProject = new Project()}).Show();
        }
    }
 }
