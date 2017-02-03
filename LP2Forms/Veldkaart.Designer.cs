namespace LP2Forms
{
    partial class Veldkaart
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
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.btnBeginBezoek = new System.Windows.Forms.Button();
            this.btnBeeindigBezoek = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.Image = global::LP2Forms.Properties.Resources.lege_veldkaart;
            this.pbMap.Location = new System.Drawing.Point(50, 82);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(763, 559);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            this.pbMap.Click += new System.EventHandler(this.pbMap_Click);
            // 
            // btnBeginBezoek
            // 
            this.btnBeginBezoek.Location = new System.Drawing.Point(711, 53);
            this.btnBeginBezoek.Name = "btnBeginBezoek";
            this.btnBeginBezoek.Size = new System.Drawing.Size(102, 23);
            this.btnBeginBezoek.TabIndex = 1;
            this.btnBeginBezoek.Text = "Begin bezoek";
            this.btnBeginBezoek.UseVisualStyleBackColor = true;
            this.btnBeginBezoek.Click += new System.EventHandler(this.btnBeginBezoek_Click);
            // 
            // btnBeeindigBezoek
            // 
            this.btnBeeindigBezoek.Location = new System.Drawing.Point(711, 53);
            this.btnBeeindigBezoek.Name = "btnBeeindigBezoek";
            this.btnBeeindigBezoek.Size = new System.Drawing.Size(102, 23);
            this.btnBeeindigBezoek.TabIndex = 2;
            this.btnBeeindigBezoek.Text = "Eind bezoek";
            this.btnBeeindigBezoek.UseVisualStyleBackColor = true;
            this.btnBeeindigBezoek.Visible = false;
            this.btnBeeindigBezoek.Click += new System.EventHandler(this.btnBeeindigBezoek_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(47, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(612, 53);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 4;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // Veldkaart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 653);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnBeeindigBezoek);
            this.Controls.Add(this.btnBeginBezoek);
            this.Controls.Add(this.pbMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Veldkaart";
            this.Text = "Veldkaart";
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Button btnBeginBezoek;
        private System.Windows.Forms.Button btnBeeindigBezoek;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnOpslaan;
    }
}