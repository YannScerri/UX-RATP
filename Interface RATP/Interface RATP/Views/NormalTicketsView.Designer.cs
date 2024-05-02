namespace Interface_RATP
{
    partial class NormalTicketsView
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSpanish = new System.Windows.Forms.Label();
            this.lblItalian = new System.Windows.Forms.Label();
            this.lblGerman = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblFrench = new System.Windows.Forms.Label();
            this.pnlNormalTickets = new System.Windows.Forms.Panel();
            this.lblAdult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReduction = new System.Windows.Forms.Label();
            this.btnBuySpecial = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAddAdultTicket = new System.Windows.Forms.Button();
            this.lblNumberOfAdultTicket = new System.Windows.Forms.Label();
            this.btnRemoveAdultTicket = new System.Windows.Forms.Button();
            this.btnRemoveReducedTicket = new System.Windows.Forms.Button();
            this.lblNumberOfReducedTicket = new System.Windows.Forms.Label();
            this.btnAddReducedTicket = new System.Windows.Forms.Button();
            this.lblCurrentPriceText = new System.Windows.Forms.Label();
            this.lblCurrentPriceInt = new System.Windows.Forms.Label();
            this.pnlLanguage.SuspendLayout();
            this.pnlNormalTickets.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlLanguage.Location = new System.Drawing.Point(1, 2);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(948, 78);
            this.pnlLanguage.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(21, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 31);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.lblSpanish.Click += new System.EventHandler(this.lblSpanish_Click);
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
            this.lblGerman.Click += new System.EventHandler(this.lblGerman_Click);
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
            this.lblEnglish.Click += new System.EventHandler(this.lblEnglish_Click);
            // 
            // lblFrench
            // 
            this.lblFrench.AutoSize = true;
            this.lblFrench.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrench.Location = new System.Drawing.Point(133, 23);
            this.lblFrench.Name = "lblFrench";
            this.lblFrench.Size = new System.Drawing.Size(96, 27);
            this.lblFrench.TabIndex = 0;
            this.lblFrench.Text = "Français";
            this.lblFrench.Click += new System.EventHandler(this.lblFrench_Click);
            // 
            // pnlNormalTickets
            // 
            this.pnlNormalTickets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlNormalTickets.Controls.Add(this.lblAdult);
            this.pnlNormalTickets.Location = new System.Drawing.Point(1, 131);
            this.pnlNormalTickets.Name = "pnlNormalTickets";
            this.pnlNormalTickets.Size = new System.Drawing.Size(501, 150);
            this.pnlNormalTickets.TabIndex = 3;
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.Location = new System.Drawing.Point(194, 64);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(120, 27);
            this.lblAdult.TabIndex = 0;
            this.lblAdult.Text = "Adulte - 5€";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblReduction);
            this.panel1.Location = new System.Drawing.Point(1, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 158);
            this.panel1.TabIndex = 4;
            // 
            // lblReduction
            // 
            this.lblReduction.AutoSize = true;
            this.lblReduction.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReduction.Location = new System.Drawing.Point(156, 66);
            this.lblReduction.Name = "lblReduction";
            this.lblReduction.Size = new System.Drawing.Size(158, 27);
            this.lblReduction.TabIndex = 1;
            this.lblReduction.Text = "Prix réduit - 2€";
            this.lblReduction.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuySpecial
            // 
            this.btnBuySpecial.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuySpecial.Location = new System.Drawing.Point(80, 683);
            this.btnBuySpecial.Name = "btnBuySpecial";
            this.btnBuySpecial.Size = new System.Drawing.Size(235, 69);
            this.btnBuySpecial.TabIndex = 5;
            this.btnBuySpecial.Text = "Acheter un billet spécial";
            this.btnBuySpecial.UseVisualStyleBackColor = true;
            this.btnBuySpecial.Click += new System.EventHandler(this.btnBuySpecial_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(568, 683);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(235, 69);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Payer";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnAddAdultTicket
            // 
            this.btnAddAdultTicket.Location = new System.Drawing.Point(810, 195);
            this.btnAddAdultTicket.Name = "btnAddAdultTicket";
            this.btnAddAdultTicket.Size = new System.Drawing.Size(47, 32);
            this.btnAddAdultTicket.TabIndex = 7;
            this.btnAddAdultTicket.Text = "+";
            this.btnAddAdultTicket.UseVisualStyleBackColor = true;
            this.btnAddAdultTicket.Click += new System.EventHandler(this.btnAddAdultTicket_Click);
            // 
            // lblNumberOfAdultTicket
            // 
            this.lblNumberOfAdultTicket.AutoSize = true;
            this.lblNumberOfAdultTicket.Location = new System.Drawing.Point(767, 205);
            this.lblNumberOfAdultTicket.Name = "lblNumberOfAdultTicket";
            this.lblNumberOfAdultTicket.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfAdultTicket.TabIndex = 8;
            this.lblNumberOfAdultTicket.Text = "0";
            // 
            // btnRemoveAdultTicket
            // 
            this.btnRemoveAdultTicket.Location = new System.Drawing.Point(685, 195);
            this.btnRemoveAdultTicket.Name = "btnRemoveAdultTicket";
            this.btnRemoveAdultTicket.Size = new System.Drawing.Size(47, 32);
            this.btnRemoveAdultTicket.TabIndex = 9;
            this.btnRemoveAdultTicket.Text = "-";
            this.btnRemoveAdultTicket.UseVisualStyleBackColor = true;
            this.btnRemoveAdultTicket.Click += new System.EventHandler(this.btnRemoveAdultTicket_Click);
            // 
            // btnRemoveReducedTicket
            // 
            this.btnRemoveReducedTicket.Location = new System.Drawing.Point(685, 389);
            this.btnRemoveReducedTicket.Name = "btnRemoveReducedTicket";
            this.btnRemoveReducedTicket.Size = new System.Drawing.Size(47, 32);
            this.btnRemoveReducedTicket.TabIndex = 12;
            this.btnRemoveReducedTicket.Text = "-";
            this.btnRemoveReducedTicket.UseVisualStyleBackColor = true;
            this.btnRemoveReducedTicket.Click += new System.EventHandler(this.btnRemoveReducedTicket_Click);
            // 
            // lblNumberOfReducedTicket
            // 
            this.lblNumberOfReducedTicket.AutoSize = true;
            this.lblNumberOfReducedTicket.Location = new System.Drawing.Point(767, 399);
            this.lblNumberOfReducedTicket.Name = "lblNumberOfReducedTicket";
            this.lblNumberOfReducedTicket.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfReducedTicket.TabIndex = 11;
            this.lblNumberOfReducedTicket.Text = "0";
            // 
            // btnAddReducedTicket
            // 
            this.btnAddReducedTicket.Location = new System.Drawing.Point(810, 389);
            this.btnAddReducedTicket.Name = "btnAddReducedTicket";
            this.btnAddReducedTicket.Size = new System.Drawing.Size(47, 32);
            this.btnAddReducedTicket.TabIndex = 10;
            this.btnAddReducedTicket.Text = "+";
            this.btnAddReducedTicket.UseVisualStyleBackColor = true;
            this.btnAddReducedTicket.Click += new System.EventHandler(this.btnAddReducedTicket_Click);
            // 
            // lblCurrentPriceText
            // 
            this.lblCurrentPriceText.AutoSize = true;
            this.lblCurrentPriceText.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPriceText.Location = new System.Drawing.Point(694, 585);
            this.lblCurrentPriceText.Name = "lblCurrentPriceText";
            this.lblCurrentPriceText.Size = new System.Drawing.Size(95, 20);
            this.lblCurrentPriceText.TabIndex = 13;
            this.lblCurrentPriceText.Text = "Total actuel :";
            // 
            // lblCurrentPriceInt
            // 
            this.lblCurrentPriceInt.AutoSize = true;
            this.lblCurrentPriceInt.Location = new System.Drawing.Point(807, 589);
            this.lblCurrentPriceInt.Name = "lblCurrentPriceInt";
            this.lblCurrentPriceInt.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentPriceInt.TabIndex = 14;
            this.lblCurrentPriceInt.Text = "0";
            // 
            // NormalTicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(947, 781);
            this.Controls.Add(this.lblCurrentPriceInt);
            this.Controls.Add(this.lblCurrentPriceText);
            this.Controls.Add(this.btnRemoveReducedTicket);
            this.Controls.Add(this.lblNumberOfReducedTicket);
            this.Controls.Add(this.btnAddReducedTicket);
            this.Controls.Add(this.btnRemoveAdultTicket);
            this.Controls.Add(this.lblNumberOfAdultTicket);
            this.Controls.Add(this.btnAddAdultTicket);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnBuySpecial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNormalTickets);
            this.Controls.Add(this.pnlLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NormalTicketsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billets normaux";
            this.pnlLanguage.ResumeLayout(false);
            this.pnlLanguage.PerformLayout();
            this.pnlNormalTickets.ResumeLayout(false);
            this.pnlNormalTickets.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.Label lblSpanish;
        private System.Windows.Forms.Label lblItalian;
        private System.Windows.Forms.Label lblGerman;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblFrench;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlNormalTickets;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReduction;
        private System.Windows.Forms.Button btnBuySpecial;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAddAdultTicket;
        private System.Windows.Forms.Label lblNumberOfAdultTicket;
        private System.Windows.Forms.Button btnRemoveAdultTicket;
        private System.Windows.Forms.Button btnRemoveReducedTicket;
        private System.Windows.Forms.Label lblNumberOfReducedTicket;
        private System.Windows.Forms.Button btnAddReducedTicket;
        private System.Windows.Forms.Label lblCurrentPriceText;
        private System.Windows.Forms.Label lblCurrentPriceInt;
    }
}