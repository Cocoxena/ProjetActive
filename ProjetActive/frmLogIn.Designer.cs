namespace ProjetActive
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotdePasse = new System.Windows.Forms.TextBox();
            this.lblMotdePasse = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identifiantOubliéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motDePasseOubliéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.aProposDeABIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkSeSouvenir = new System.Windows.Forms.CheckBox();
            this.menuStripLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(289, 207);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(216, 20);
            this.txtIdentifiant.TabIndex = 1;
            this.txtIdentifiant.TextChanged += new System.EventHandler(this.txtIdentifiant_TextChanged);
            // 
            // txtMotdePasse
            // 
            this.txtMotdePasse.Location = new System.Drawing.Point(289, 257);
            this.txtMotdePasse.Name = "txtMotdePasse";
            this.txtMotdePasse.PasswordChar = '*';
            this.txtMotdePasse.Size = new System.Drawing.Size(216, 20);
            this.txtMotdePasse.TabIndex = 2;
            this.txtMotdePasse.TextChanged += new System.EventHandler(this.txtMotdePasse_TextChanged);
            // 
            // lblMotdePasse
            // 
            this.lblMotdePasse.AutoSize = true;
            this.lblMotdePasse.Location = new System.Drawing.Point(192, 260);
            this.lblMotdePasse.Name = "lblMotdePasse";
            this.lblMotdePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotdePasse.TabIndex = 4;
            this.lblMotdePasse.Text = "Mot de passe";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(192, 210);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 5;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(532, 255);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(662, 376);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(246, 84);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(332, 50);
            this.lblTitre.TabIndex = 9;
            this.lblTitre.Text = "Bienvenue sur l\'application Active";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identifiantOubliéToolStripMenuItem,
            this.motDePasseOubliéToolStripMenuItem,
            this.aideToolStripMenuItem1});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // identifiantOubliéToolStripMenuItem
            // 
            this.identifiantOubliéToolStripMenuItem.Name = "identifiantOubliéToolStripMenuItem";
            this.identifiantOubliéToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.identifiantOubliéToolStripMenuItem.Text = "Identifiant oublié";
            // 
            // motDePasseOubliéToolStripMenuItem
            // 
            this.motDePasseOubliéToolStripMenuItem.Name = "motDePasseOubliéToolStripMenuItem";
            this.motDePasseOubliéToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motDePasseOubliéToolStripMenuItem.Text = "Mot de passe oublié";
            // 
            // aideToolStripMenuItem1
            // 
            this.aideToolStripMenuItem1.Name = "aideToolStripMenuItem1";
            this.aideToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aideToolStripMenuItem1.Text = "Aide ";
            // 
            // menuStripLogin
            // 
            this.menuStripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.aProposDeABIToolStripMenuItem});
            this.menuStripLogin.Location = new System.Drawing.Point(0, 0);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Size = new System.Drawing.Size(764, 24);
            this.menuStripLogin.TabIndex = 7;
            this.menuStripLogin.Text = "menuStrip2";
            // 
            // aProposDeABIToolStripMenuItem
            // 
            this.aProposDeABIToolStripMenuItem.Name = "aProposDeABIToolStripMenuItem";
            this.aProposDeABIToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.aProposDeABIToolStripMenuItem.Text = "A propos de ABI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // chkSeSouvenir
            // 
            this.chkSeSouvenir.AutoSize = true;
            this.chkSeSouvenir.Location = new System.Drawing.Point(289, 307);
            this.chkSeSouvenir.Name = "chkSeSouvenir";
            this.chkSeSouvenir.Size = new System.Drawing.Size(116, 17);
            this.chkSeSouvenir.TabIndex = 11;
            this.chkSeSouvenir.Text = "Se souvenir de moi";
            this.chkSeSouvenir.UseVisualStyleBackColor = true;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 420);
            this.Controls.Add(this.chkSeSouvenir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblMotdePasse);
            this.Controls.Add(this.txtMotdePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.menuStripLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmLogIn";
            this.Text = "LogIn Active Platform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogIn_FormClosing);
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.menuStripLogin.ResumeLayout(false);
            this.menuStripLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotdePasse;
        private System.Windows.Forms.Label lblMotdePasse;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identifiantOubliéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motDePasseOubliéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkSeSouvenir;
        private System.Windows.Forms.ToolStripMenuItem aProposDeABIToolStripMenuItem;
    }
}

