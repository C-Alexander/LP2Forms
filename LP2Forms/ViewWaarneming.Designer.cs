namespace LP2Forms
{
    partial class ViewWaarneming
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
            this.dtpViewW = new System.Windows.Forms.DateTimePicker();
            this.lblDier = new System.Windows.Forms.Label();
            this.lblSoort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpViewW
            // 
            this.dtpViewW.Enabled = false;
            this.dtpViewW.Location = new System.Drawing.Point(43, 149);
            this.dtpViewW.Name = "dtpViewW";
            this.dtpViewW.Size = new System.Drawing.Size(200, 20);
            this.dtpViewW.TabIndex = 0;
            // 
            // lblDier
            // 
            this.lblDier.AutoSize = true;
            this.lblDier.Location = new System.Drawing.Point(62, 48);
            this.lblDier.Name = "lblDier";
            this.lblDier.Size = new System.Drawing.Size(0, 13);
            this.lblDier.TabIndex = 1;
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(65, 83);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(0, 13);
            this.lblSoort.TabIndex = 2;
            // 
            // ViewWaarneming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSoort);
            this.Controls.Add(this.lblDier);
            this.Controls.Add(this.dtpViewW);
            this.Name = "ViewWaarneming";
            this.Text = "ViewWaarneming";
            this.Load += new System.EventHandler(this.ViewWaarneming_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpViewW;
        private System.Windows.Forms.Label lblDier;
        private System.Windows.Forms.Label lblSoort;
    }
}