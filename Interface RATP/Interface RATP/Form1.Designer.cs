namespace Interface_RATP
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.lblSpanish = new System.Windows.Forms.Label();
            this.lblItalian = new System.Windows.Forms.Label();
            this.lblGerman = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblFrench = new System.Windows.Forms.Label();
            this.pnlNormalTickets = new System.Windows.Forms.Panel();
            this.picboxNormalTicket = new System.Windows.Forms.PictureBox();
            this.lblNormalTickets = new System.Windows.Forms.Label();
            this.pnlSpecialTickets = new System.Windows.Forms.Panel();
            this.lblSpecialTickets = new System.Windows.Forms.Label();
            this.picBoxSpecialTicket = new System.Windows.Forms.PictureBox();
            this.btnNormalHelp = new System.Windows.Forms.Button();
            this.btnSpecialHelp = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLanguage.SuspendLayout();
            this.pnlNormalTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNormalTicket)).BeginInit();
            this.pnlSpecialTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSpecialTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlLanguage.Controls.Add(this.lblSpanish);
            this.pnlLanguage.Controls.Add(this.lblItalian);
            this.pnlLanguage.Controls.Add(this.lblGerman);
            this.pnlLanguage.Controls.Add(this.lblEnglish);
            this.pnlLanguage.Controls.Add(this.lblFrench);
            this.pnlLanguage.Location = new System.Drawing.Point(-1, -1);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(949, 75);
            this.pnlLanguage.TabIndex = 0;
            // 
            // lblSpanish
            // 
            this.lblSpanish.AutoSize = true;
            this.lblSpanish.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpanish.Location = new System.Drawing.Point(383, 23);
            this.lblSpanish.Name = "lblSpanish";
            this.lblSpanish.Size = new System.Drawing.Size(90, 27);
            this.lblSpanish.TabIndex = 4;
            this.lblSpanish.Text = "Español";
            // 
            // lblItalian
            // 
            this.lblItalian.AutoSize = true;
            this.lblItalian.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItalian.Location = new System.Drawing.Point(668, 23);
            this.lblItalian.Name = "lblItalian";
            this.lblItalian.Size = new System.Drawing.Size(85, 27);
            this.lblItalian.TabIndex = 3;
            this.lblItalian.Text = "Italiano";
            // 
            // lblGerman
            // 
            this.lblGerman.AutoSize = true;
            this.lblGerman.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerman.Location = new System.Drawing.Point(517, 23);
            this.lblGerman.Name = "lblGerman";
            this.lblGerman.Size = new System.Drawing.Size(93, 27);
            this.lblGerman.TabIndex = 2;
            this.lblGerman.Text = "Deutsch";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(259, 23);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(84, 27);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.Text = "English\r\n";
            // 
            // lblFrench
            // 
            this.lblFrench.AutoSize = true;
            this.lblFrench.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrench.Location = new System.Drawing.Point(118, 23);
            this.lblFrench.Name = "lblFrench";
            this.lblFrench.Size = new System.Drawing.Size(96, 27);
            this.lblFrench.TabIndex = 0;
            this.lblFrench.Text = "Français";
            this.lblFrench.Click += new System.EventHandler(this.lblFrench_Click);
            // 
            // pnlNormalTickets
            // 
            this.pnlNormalTickets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlNormalTickets.Controls.Add(this.btnNormalHelp);
            this.pnlNormalTickets.Controls.Add(this.picboxNormalTicket);
            this.pnlNormalTickets.Controls.Add(this.lblNormalTickets);
            this.pnlNormalTickets.Location = new System.Drawing.Point(91, 243);
            this.pnlNormalTickets.Name = "pnlNormalTickets";
            this.pnlNormalTickets.Size = new System.Drawing.Size(328, 376);
            this.pnlNormalTickets.TabIndex = 2;
            // 
            // picboxNormalTicket
            // 
            this.picboxNormalTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxNormalTicket.BackgroundImage")));
            this.picboxNormalTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxNormalTicket.Location = new System.Drawing.Point(39, 100);
            this.picboxNormalTicket.Name = "picboxNormalTicket";
            this.picboxNormalTicket.Size = new System.Drawing.Size(262, 129);
            this.picboxNormalTicket.TabIndex = 1;
            this.picboxNormalTicket.TabStop = false;
            // 
            // lblNormalTickets
            // 
            this.lblNormalTickets.AutoSize = true;
            this.lblNormalTickets.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalTickets.Location = new System.Drawing.Point(77, 38);
            this.lblNormalTickets.Name = "lblNormalTickets";
            this.lblNormalTickets.Size = new System.Drawing.Size(177, 27);
            this.lblNormalTickets.TabIndex = 0;
            this.lblNormalTickets.Text = "Billets standards";
            this.lblNormalTickets.Click += new System.EventHandler(this.lblNormalTickets_Click);
            // 
            // pnlSpecialTickets
            // 
            this.pnlSpecialTickets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSpecialTickets.Controls.Add(this.btnSpecialHelp);
            this.pnlSpecialTickets.Controls.Add(this.picBoxSpecialTicket);
            this.pnlSpecialTickets.Controls.Add(this.lblSpecialTickets);
            this.pnlSpecialTickets.Location = new System.Drawing.Point(560, 243);
            this.pnlSpecialTickets.Name = "pnlSpecialTickets";
            this.pnlSpecialTickets.Size = new System.Drawing.Size(328, 376);
            this.pnlSpecialTickets.TabIndex = 3;
            // 
            // lblSpecialTickets
            // 
            this.lblSpecialTickets.AutoSize = true;
            this.lblSpecialTickets.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialTickets.Location = new System.Drawing.Point(90, 38);
            this.lblSpecialTickets.Name = "lblSpecialTickets";
            this.lblSpecialTickets.Size = new System.Drawing.Size(166, 27);
            this.lblSpecialTickets.TabIndex = 1;
            this.lblSpecialTickets.Text = "Billets spéciaux";
            this.lblSpecialTickets.Click += new System.EventHandler(this.lblSpecialTickets_Click);
            // 
            // picBoxSpecialTicket
            // 
            this.picBoxSpecialTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxSpecialTicket.BackgroundImage")));
            this.picBoxSpecialTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxSpecialTicket.Location = new System.Drawing.Point(38, 100);
            this.picBoxSpecialTicket.Name = "picBoxSpecialTicket";
            this.picBoxSpecialTicket.Size = new System.Drawing.Size(262, 129);
            this.picBoxSpecialTicket.TabIndex = 2;
            this.picBoxSpecialTicket.TabStop = false;
            // 
            // btnNormalHelp
            // 
            this.btnNormalHelp.BackColor = System.Drawing.Color.Azure;
            this.btnNormalHelp.Location = new System.Drawing.Point(120, 303);
            this.btnNormalHelp.Name = "btnNormalHelp";
            this.btnNormalHelp.Size = new System.Drawing.Size(81, 45);
            this.btnNormalHelp.TabIndex = 2;
            this.btnNormalHelp.Text = "?";
            this.btnNormalHelp.UseVisualStyleBackColor = false;
            this.btnNormalHelp.Click += new System.EventHandler(this.btnNormalHelp_Click);
            // 
            // btnSpecialHelp
            // 
            this.btnSpecialHelp.BackColor = System.Drawing.Color.Azure;
            this.btnSpecialHelp.Location = new System.Drawing.Point(135, 303);
            this.btnSpecialHelp.Name = "btnSpecialHelp";
            this.btnSpecialHelp.Size = new System.Drawing.Size(81, 45);
            this.btnSpecialHelp.TabIndex = 3;
            this.btnSpecialHelp.Text = "?";
            this.btnSpecialHelp.UseVisualStyleBackColor = false;
            this.btnSpecialHelp.Click += new System.EventHandler(this.btnSpecialHelp_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(296, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(402, 97);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 697);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 84);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(947, 781);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pnlSpecialTickets);
            this.Controls.Add(this.pnlNormalTickets);
            this.Controls.Add(this.pnlLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Menu ";
            this.pnlLanguage.ResumeLayout(false);
            this.pnlLanguage.PerformLayout();
            this.pnlNormalTickets.ResumeLayout(false);
            this.pnlNormalTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNormalTicket)).EndInit();
            this.pnlSpecialTickets.ResumeLayout(false);
            this.pnlSpecialTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSpecialTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.Label lblItalian;
        private System.Windows.Forms.Label lblGerman;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblFrench;
        private System.Windows.Forms.Label lblSpanish;
        private System.Windows.Forms.Panel pnlNormalTickets;
        private System.Windows.Forms.Panel pnlSpecialTickets;
        private System.Windows.Forms.PictureBox picboxNormalTicket;
        private System.Windows.Forms.Label lblNormalTickets;
        private System.Windows.Forms.Label lblSpecialTickets;
        private System.Windows.Forms.Button btnNormalHelp;
        private System.Windows.Forms.PictureBox picBoxSpecialTicket;
        private System.Windows.Forms.Button btnSpecialHelp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

