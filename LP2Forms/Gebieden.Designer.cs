namespace LP2Forms
{
    partial class Gebieden
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
            this.cbGebieden = new System.Windows.Forms.ComboBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnBerekenBroedparen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbGebieden
            // 
            this.cbGebieden.FormattingEnabled = true;
            this.cbGebieden.Location = new System.Drawing.Point(152, 122);
            this.cbGebieden.Name = "cbGebieden";
            this.cbGebieden.Size = new System.Drawing.Size(177, 21);
            this.cbGebieden.TabIndex = 0;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(235, 168);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnBerekenBroedparen
            // 
            this.btnBerekenBroedparen.Location = new System.Drawing.Point(334, 12);
            this.btnBerekenBroedparen.Name = "btnBerekenBroedparen";
            this.btnBerekenBroedparen.Size = new System.Drawing.Size(132, 23);
            this.btnBerekenBroedparen.TabIndex = 2;
            this.btnBerekenBroedparen.Text = "Bereken Broedparen";
            this.btnBerekenBroedparen.UseVisualStyleBackColor = true;
            this.btnBerekenBroedparen.Click += new System.EventHandler(this.btnBerekenBroedparen_Click);
            // 
            // Gebieden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 356);
            this.Controls.Add(this.btnBerekenBroedparen);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.cbGebieden);
            this.Name = "Gebieden";
            this.Text = "Gebieden";
            this.Activated += new System.EventHandler(this.Gebieden_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGebieden;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnBerekenBroedparen;
    }
}