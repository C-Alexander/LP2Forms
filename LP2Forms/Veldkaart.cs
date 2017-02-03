using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LP2Forms.DomeinModellen;

namespace LP2Forms
{
    public partial class Veldkaart : Form
    {
        private readonly Gebied _gebied;

        public Veldkaart(Gebied gebied)
        {
            _gebied = gebied;
            InitializeComponent();
            if (_gebied.Asset != null)
                pbMap.ImageLocation = _gebied.Asset;
        }

        private void pbMap_Click(object sender, EventArgs e)
        {
            if (_gebied.ActiefProject.Bezoeken == null || _gebied.ActiefProject.Bezoeken.Count == 0 ||
                _gebied.ActiefProject.Bezoeken.Last().EindBezoek != DateTime.MinValue)
            {
                lblError.Text = "Begin alstublieft een nieuw bezoek voordat u een waarneming toevoegt.";
            }
            else
            {
                var nieuweWaarnemingForm = new NieuweWaarneming();
                Console.WriteLine("X: " + MousePosition.X + "Y: " + MousePosition.Y);
                nieuweWaarnemingForm.Waarneming.XCoordinaten = MousePosition.X;
                nieuweWaarnemingForm.Waarneming.YCoordinaten = MousePosition.Y;
                Console.WriteLine("X: " + MousePosition.X + "Y: " + MousePosition.Y);
                nieuweWaarnemingForm.ShowDialog();
                _gebied.ActiefProject.Bezoeken.Last().Waarnemingen.Add(nieuweWaarnemingForm.Waarneming);
                var waarneming = _gebied.ActiefProject.Bezoeken.Last().Waarnemingen.Last();
                DrawWaarneming(ref waarneming);
            }
        }

        public void DrawWaarneming(ref Waarneming waarneming)
        {
            //draw us a picture box!!
            var waarnemingPictureBox = new PictureBox();
            var resManager = Properties.Resources.ResourceManager;
            if (waarneming.WaarnemingsSoort.Asset != null)
            waarnemingPictureBox.Image = (Bitmap) resManager.GetObject(waarneming.WaarnemingsSoort.Asset);
            if (waarnemingPictureBox.Image != null)
            {
                waarnemingPictureBox.Size = waarnemingPictureBox.Image.Size;
                waarnemingPictureBox.Location = pbMap.PointToClient(new Point(waarneming.XCoordinaten, waarneming.YCoordinaten));
                Controls.Add(waarnemingPictureBox);
                waarnemingPictureBox.BringToFront();
                waarnemingPictureBox.Show();
                waarnemingPictureBox.Parent = pbMap;
                waarneming.PictureBox = waarnemingPictureBox;

                //label now
                var dierLabel = new Label();
                dierLabel.Text = waarneming.Dier.Afkorting;
                dierLabel.BackColor = Color.Transparent;
                dierLabel.ForeColor = Color.Violet;
                dierLabel.Location = pbMap.PointToClient(new Point(waarneming.XCoordinaten, waarneming.YCoordinaten) + waarnemingPictureBox.Image.Size);
                Controls.Add(dierLabel);
                dierLabel.BringToFront();
                dierLabel.Show();
                dierLabel.Parent = pbMap; //needed for transperancy

                waarnemingPictureBox.Click += waarneming.OnClick;
                dierLabel.Click += waarneming.OnClick;
            }
            Console.WriteLine("X2: " + waarnemingPictureBox.Location.X + "Y2: " + waarnemingPictureBox.Location.Y);
        }

        private void btnBeeindigBezoek_Click(object sender, EventArgs e)
        {
            _gebied.ActiefProject.Bezoeken.Last().EindBezoek = DateTime.Now;
            btnBeginBezoek.Show();
            btnBeeindigBezoek.Hide();
        }

        private void btnBeginBezoek_Click(object sender, EventArgs e)
        {
            _gebied.ActiefProject.Bezoeken.Add(new Bezoek()
            {
                BeginBezoek = DateTime.Now
            });
            btnBeginBezoek.Hide();
            btnBeeindigBezoek.Show();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            _gebied.ToXML();

        }
    }
}
