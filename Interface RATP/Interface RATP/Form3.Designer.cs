namespace Interface_RATP
{
    partial class SpecialTickets
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
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.lblSpanish = new System.Windows.Forms.Label();
            this.lblItalian = new System.Windows.Forms.Label();
            this.lblGerman = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblFrench = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlLanguage.Controls.Add(this.btnBack);
            this.pnlLanguage.Controls.Add(this.lblSpanish);
            this.pnlLanguage.Controls.Add(this.lblItalian);
            this.pnlLanguage.Controls.Add(this.lblGerman);
            this.pnlLanguage.Controls.Add(this.lblEnglish);
            this.pnlLanguage.Controls.Add(this.lblFrench);
            this.pnlLanguage.Location = new System.Drawing.Point(1, 1);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(948, 78);
            this.pnlLanguage.TabIndex = 2;
            // 
            // lblSpanish
            // 
            this.lblSpanish.AutoSize = true;
            this.lblSpanish.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpanish.Location = new System.Drawing.Point(474, 23);
            this.lblSpanish.Name = "lblSpanish";
            this.lblSpanish.Size = new System.Drawing.Size(90, 27);
            this.lblSpanish.TabIndex = 4;
            this.lblSpanish.Text = "Español";
            // 
            // lblItalian
            // 
            this.lblItalian.AutoSize = true;
            this.lblItalian.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItalian.Location = new System.Drawing.Point(804, 23);
            this.lblItalian.Name = "lblItalian";
            this.lblItalian.Size = new System.Drawing.Size(85, 27);
            this.lblItalian.TabIndex = 3;
            this.lblItalian.Text = "Italiano";
            // 
            // lblGerman
            // 
            this.lblGerman.AutoSize = true;
            this.lblGerman.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerman.Location = new System.Drawing.Point(638, 23);
            this.lblGerman.Name = "lblGerman";
            this.lblGerman.Size = new System.Drawing.Size(93, 27);
            this.lblGerman.TabIndex = 2;
            this.lblGerman.Text = "Deutsch";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(302, 23);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(84, 27);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.Text = "English\r\n";
            // 
            // lblFrench
            // 
            this.lblFrench.AutoSize = true;
            this.lblFrench.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrench.Location = new System.Drawing.Point(161, 24);
            this.lblFrench.Name = "lblFrench";
            this.lblFrench.Size = new System.Drawing.Size(96, 27);
            this.lblFrench.TabIndex = 0;
            this.lblFrench.Text = "Français";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(26, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SpecialTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 781);
            this.Controls.Add(this.pnlLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpecialTickets";
            this.Text = "Billets spéciaux";
            this.pnlLanguage.ResumeLayout(false);
            this.pnlLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.Label lblSpanish;
        private System.Windows.Forms.Label lblItalian;
        private System.Windows.Forms.Label lblGerman;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblFrench;
        private System.Windows.Forms.Button btnBack;
    }
}