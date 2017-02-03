namespace LP2Forms
{
    partial class NieuweWaarneming
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
            this.cbDier = new System.Windows.Forms.ComboBox();
            this.cbWaarnemingsSoort = new System.Windows.Forms.ComboBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.dtpWaarnemingsTijd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbDier
            // 
            this.cbDier.FormattingEnabled = true;
            this.cbDier.Location = new System.Drawing.Point(39, 57);
            this.cbDier.Name = "cbDier";
            this.cbDier.Size = new System.Drawing.Size(201, 21);
            this.cbDier.TabIndex = 0;
            this.cbDier.SelectedIndexChanged += new System.EventHandler(this.cbDier_SelectedIndexChanged);
            // 
            // cbWaarnemingsSoort
            // 
            this.cbWaarnemingsSoort.FormattingEnabled = true;
            this.cbWaarnemingsSoort.Location = new System.Drawing.Point(39, 85);
            this.cbWaarnemingsSoort.Name = "cbWaarnemingsSoort";
            this.cbWaarnemingsSoort.Size = new System.Drawing.Size(201, 21);
            this.cbWaarnemingsSoort.TabIndex = 1;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(197, 226);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 2;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // dtpWaarnemingsTijd
            // 
            this.dtpWaarnemingsTijd.Enabled = false;
            this.dtpWaarnemingsTijd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWaarnemingsTijd.Location = new System.Drawing.Point(39, 132);
            this.dtpWaarnemingsTijd.Name = "dtpWaarnemingsTijd";
            this.dtpWaarnemingsTijd.Size = new System.Drawing.Size(200, 20);
            this.dtpWaarnemingsTijd.TabIndex = 3;
            this.dtpWaarnemingsTijd.Value = new System.DateTime(2017, 2, 2, 11, 30, 3, 0);
            // 
            // NieuweWaarneming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dtpWaarnemingsTijd);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.cbWaarnemingsSoort);
            this.Controls.Add(this.cbDier);
            this.Name = "NieuweWaarneming";
            this.Text = "NieuweWaarneming";
            this.Load += new System.EventHandler(this.NieuweWaarneming_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDier;
        private System.Windows.Forms.ComboBox cbWaarnemingsSoort;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.DateTimePicker dtpWaarnemingsTijd;
    }
}