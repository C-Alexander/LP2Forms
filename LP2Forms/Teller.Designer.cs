namespace LP2Forms
{
    partial class Teller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTeller = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTeller
            // 
            this.lbTeller.FormattingEnabled = true;
            this.lbTeller.Location = new System.Drawing.Point(13, 13);
            this.lbTeller.Name = "lbTeller";
            this.lbTeller.Size = new System.Drawing.Size(515, 602);
            this.lbTeller.TabIndex = 0;
            // 
            // Teller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 629);
            this.Controls.Add(this.lbTeller);
            this.Name = "Teller";
            this.Text = "Teller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeller;
    }
}