namespace LP2Forms
{
    partial class Login
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.TbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.skipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LP2Forms.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(204, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(217, 212);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnRegistreer);
            this.gbLogin.Controls.Add(this.lblErrors);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.lblWachtwoord);
            this.gbLogin.Controls.Add(this.lblGebruikersnaam);
            this.gbLogin.Controls.Add(this.TbWachtwoord);
            this.gbLogin.Controls.Add(this.tbGebruikersnaam);
            this.gbLogin.Location = new System.Drawing.Point(143, 221);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(340, 189);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(62, 121);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreer.TabIndex = 6;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(42, 96);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 13);
            this.lblErrors.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(236, 121);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(6, 59);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lblWachtwoord.TabIndex = 3;
            this.lblWachtwoord.Text = "Wachtwoord:";  
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(6, 33);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lblGebruikersnaam.TabIndex = 2;
            this.lblGebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // TbWachtwoord
            // 
            this.TbWachtwoord.Location = new System.Drawing.Point(125, 56);
            this.TbWachtwoord.Name = "TbWachtwoord";
            this.TbWachtwoord.PasswordChar = '*';
            this.TbWachtwoord.Size = new System.Drawing.Size(187, 20);
            this.TbWachtwoord.TabIndex = 1;
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Location = new System.Drawing.Point(125, 30);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(187, 20);
            this.tbGebruikersnaam.TabIndex = 0;
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(527, 12);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(99, 23);
            this.skipButton.TabIndex = 5;
            this.skipButton.Text = "Geen Internet";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 469);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.pbLogo);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.TextBox TbWachtwoord;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Button skipButton;
    }
}

