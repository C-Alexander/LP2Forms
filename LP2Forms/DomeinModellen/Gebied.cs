using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LP2Forms.DomeinModellen
{
    public class Gebied
    {
        public string Naam { get; set; }
        public string Asset { get; set; }
        public Project ActiefProject { get; set; }
        public int Id { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Naam;
        }

        public string ToXML()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = ".xml";
                sfd.Filter = @"XML File|*.xml";
                sfd.CreatePrompt = true;
                sfd.OverwritePrompt = true;
                sfd.ShowDialog();
                XmlSerializer x = new XmlSerializer(GetType());
                x.Serialize(sfd.OpenFile(), this);
                return x.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Oops, something went very wrong! Please try again."); //just in case.
            }
            return "";
        }

    }
}