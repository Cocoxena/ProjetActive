namespace ProjetActive
{
    partial class frmAccu
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
            this.menuStripAccueil = new System.Windows.Forms.MenuStrip();
            this.gestionRessourcesHumainesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProjetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommercialeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneFicheClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierIntervenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelIntervenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnIntervenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnIntervenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierDocumentationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAccueil
            // 
            this.menuStripAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionRessourcesHumainesToolStripMenuItem,
            this.gestionProjetsToolStripMenuItem,
            this.gestionCommercialeToolStripMenuItem,
            this.seDéconnecterToolStripMenuItem});
            this.menuStripAccueil.Location = new System.Drawing.Point(0, 0);
            this.menuStripAccueil.Name = "menuStripAccueil";
            this.menuStripAccueil.Size = new System.Drawing.Size(960, 24);
            this.menuStripAccueil.TabIndex = 0;
            this.menuStripAccueil.Text = "menuStrip1";
            // 
            // gestionRessourcesHumainesToolStripMenuItem
            // 
            this.gestionRessourcesHumainesToolStripMenuItem.Name = "gestionRessourcesHumainesToolStripMenuItem";
            this.gestionRessourcesHumainesToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.gestionRessourcesHumainesToolStripMenuItem.Text = "Gestion Ressources Humaines";
            // 
            // gestionProjetsToolStripMenuItem
            // 
            this.gestionProjetsToolStripMenuItem.Name = "gestionProjetsToolStripMenuItem";
            this.gestionProjetsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gestionProjetsToolStripMenuItem.Text = "Gestion Projets";
            // 
            // gestionCommercialeToolStripMenuItem
            // 
            this.gestionCommercialeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierClientsToolStripMenuItem,
            this.fichierIntervenantsToolStripMenuItem,
            this.fichierDocumentationsToolStripMenuItem});
            this.gestionCommercialeToolStripMenuItem.Name = "gestionCommercialeToolStripMenuItem";
            this.gestionCommercialeToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.gestionCommercialeToolStripMenuItem.Text = "Gestion Commerciale";
            // 
            // fichierClientsToolStripMenuItem
            // 
            this.fichierClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem,
            this.nouveauClientToolStripMenuItem,
            this.modifierUneFicheClientToolStripMenuItem,
            this.supprimerUnClientToolStripMenuItem});
            this.fichierClientsToolStripMenuItem.Name = "fichierClientsToolStripMenuItem";
            this.fichierClientsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.fichierClientsToolStripMenuItem.Text = "Fichier Clients";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.consulterToolStripMenuItem.Text = "Consulter";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.consulterToolStripMenuItem_Click);
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau client";
            this.nouveauClientToolStripMenuItem.Click += new System.EventHandler(this.nouveauClientToolStripMenuItem_Click);
            // 
            // modifierUneFicheClientToolStripMenuItem
            // 
            this.modifierUneFicheClientToolStripMenuItem.Name = "modifierUneFicheClientToolStripMenuItem";
            this.modifierUneFicheClientToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.modifierUneFicheClientToolStripMenuItem.Text = "Modifier un client";
            this.modifierUneFicheClientToolStripMenuItem.Click += new System.EventHandler(this.modifierUneFicheClientToolStripMenuItem_Click);
            // 
            // supprimerUnClientToolStripMenuItem
            // 
            this.supprimerUnClientToolStripMenuItem.Name = "supprimerUnClientToolStripMenuItem";
            this.supprimerUnClientToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.supprimerUnClientToolStripMenuItem.Text = "Supprimer un client";
            this.supprimerUnClientToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnClientToolStripMenuItem_Click);
            // 
            // fichierIntervenantsToolStripMenuItem
            // 
            this.fichierIntervenantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem1,
            this.nouvelIntervenantToolStripMenuItem,
            this.modifierUnIntervenantToolStripMenuItem,
            this.supprimerUnIntervenantToolStripMenuItem});
            this.fichierIntervenantsToolStripMenuItem.Name = "fichierIntervenantsToolStripMenuItem";
            this.fichierIntervenantsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.fichierIntervenantsToolStripMenuItem.Text = "Fichier Intervenants";
            // 
            // consulterToolStripMenuItem1
            // 
            this.consulterToolStripMenuItem1.Name = "consulterToolStripMenuItem1";
            this.consulterToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.consulterToolStripMenuItem1.Text = "Consulter";
            // 
            // nouvelIntervenantToolStripMenuItem
            // 
            this.nouvelIntervenantToolStripMenuItem.Name = "nouvelIntervenantToolStripMenuItem";
            this.nouvelIntervenantToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.nouvelIntervenantToolStripMenuItem.Text = "Nouvel intervenant";
            // 
            // modifierUnIntervenantToolStripMenuItem
            // 
            this.modifierUnIntervenantToolStripMenuItem.Name = "modifierUnIntervenantToolStripMenuItem";
            this.modifierUnIntervenantToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modifierUnIntervenantToolStripMenuItem.Text = "Modifier un intervenant";
            // 
            // supprimerUnIntervenantToolStripMenuItem
            // 
            this.supprimerUnIntervenantToolStripMenuItem.Name = "supprimerUnIntervenantToolStripMenuItem";
            this.supprimerUnIntervenantToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.supprimerUnIntervenantToolStripMenuItem.Text = "Supprimer un intervenant";
            // 
            // fichierDocumentationsToolStripMenuItem
            // 
            this.fichierDocumentationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem2,
            this.nouvelleDocumentationToolStripMenuItem,
            this.modifierUnDocumentToolStripMenuItem,
            this.supprimerUnDocumentToolStripMenuItem});
            this.fichierDocumentationsToolStripMenuItem.Name = "fichierDocumentationsToolStripMenuItem";
            this.fichierDocumentationsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.fichierDocumentationsToolStripMenuItem.Text = "Fichier Documentation";
            // 
            // consulterToolStripMenuItem2
            // 
            this.consulterToolStripMenuItem2.Name = "consulterToolStripMenuItem2";
            this.consulterToolStripMenuItem2.Size = new System.Drawing.Size(204, 22);
            this.consulterToolStripMenuItem2.Text = "Consulter";
            // 
            // nouvelleDocumentationToolStripMenuItem
            // 
            this.nouvelleDocumentationToolStripMenuItem.Name = "nouvelleDocumentationToolStripMenuItem";
            this.nouvelleDocumentationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.nouvelleDocumentationToolStripMenuItem.Text = "Nouveau document";
            // 
            // modifierUnDocumentToolStripMenuItem
            // 
            this.modifierUnDocumentToolStripMenuItem.Name = "modifierUnDocumentToolStripMenuItem";
            this.modifierUnDocumentToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.modifierUnDocumentToolStripMenuItem.Text = "Modifier un document";
            // 
            // supprimerUnDocumentToolStripMenuItem
            // 
            this.supprimerUnDocumentToolStripMenuItem.Name = "supprimerUnDocumentToolStripMenuItem";
            this.supprimerUnDocumentToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.supprimerUnDocumentToolStripMenuItem.Text = "Supprimer un document";
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // frmAccu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(960, 566);
            this.Controls.Add(this.menuStripAccueil);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripAccueil;
            this.Name = "frmAccu";
            this.Text = "frmAccueil";
            this.Load += new System.EventHandler(this.frmAccu_Load);
            this.menuStripAccueil.ResumeLayout(false);
            this.menuStripAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAccueil;
        private System.Windows.Forms.ToolStripMenuItem gestionRessourcesHumainesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionProjetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCommercialeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierIntervenantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierDocumentationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouvelIntervenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nouvelleDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneFicheClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnIntervenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnIntervenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnDocumentToolStripMenuItem;
    }
}