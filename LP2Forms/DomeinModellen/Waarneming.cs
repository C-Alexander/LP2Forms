using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LP2Forms.DomeinModellen
{
    public class Waarneming
    {
        public DateTime WaarnemingsTijd { get; set; }
        public int XCoordinaten { get; set; }
        public int YCoordinaten { get; set; }
        public Dier Dier { get; set; }
        public WaarnemingsSoort WaarnemingsSoort { get; set; }
        [XmlIgnore]
        public PictureBox PictureBox { get; set; }

        public void OnClick(object sender, EventArgs e)
        {
            new ViewWaarneming(this).ShowDialog();
        }
    }
}