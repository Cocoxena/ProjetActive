namespace ProjetActive
{
    partial class frmClie
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRaison = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDomaine = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRaison = new System.Windows.Forms.TextBox();
            this.txtDomaine = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtTelClient = new System.Windows.Forms.TextBox();
            this.gbxCoordonnees = new System.Windows.Forms.GroupBox();
            this.rbtPublic = new System.Windows.Forms.RadioButton();
            this.rbtPrive = new System.Windows.Forms.RadioButton();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblCPVille = new System.Windows.Forms.Label();
            this.gbxChiffres = new System.Windows.Forms.GroupBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.gbxNature = new System.Windows.Forms.GroupBox();
            this.rbtAncienne = new System.Windows.Forms.RadioButton();
            this.rbtSecondaire = new System.Windows.Forms.RadioButton();
            this.rbtPrincipale = new System.Windows.Forms.RadioButton();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.gbxCoordonnees.SuspendLayout();
            this.gbxChiffres.SuspendLayout();
            this.gbxNature.SuspendLayout();
            this.gbxContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(44, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(42, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "IdClient";
            // 
            // lblRaison
            // 
            this.lblRaison.AutoSize = true;
            this.lblRaison.Location = new System.Drawing.Point(44, 71);
            this.lblRaison.Name = "lblRaison";
            this.lblRaison.Size = new System.Drawing.Size(84, 13);
            this.lblRaison.TabIndex = 1;
            this.lblRaison.Text = "Raison Sociale :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(44, 104);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type :";
            // 
            // lblDomaine
            // 
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Location = new System.Drawing.Point(44, 141);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(100, 13);
            this.lblDomaine.TabIndex = 3;
            this.lblDomaine.Text = "Domaine d\'activité :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(44, 178);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(41, 245);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 6;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(152, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(173, 20);
            this.txtNumero.TabIndex = 9;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtRaison
            // 
            this.txtRaison.Location = new System.Drawing.Point(152, 68);
            this.txtRaison.Name = "txtRaison";
            this.txtRaison.Size = new System.Drawing.Size(173, 20);
            this.txtRaison.TabIndex = 10;
            // 
            // txtDomaine
            // 
            this.txtDomaine.Location = new System.Drawing.Point(150, 138);
            this.txtDomaine.Name = "txtDomaine";
            this.txtDomaine.Size = new System.Drawing.Size(173, 20);
            this.txtDomaine.TabIndex = 12;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(150, 175);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(392, 20);
            this.txtAdresse.TabIndex = 13;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(150, 206);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 14;
            this.txtCP.TextChanged += new System.EventHandler(this.txtCP_TextChanged);
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtTelClient
            // 
            this.txtTelClient.Location = new System.Drawing.Point(150, 242);
            this.txtTelClient.Name = "txtTelClient";
            this.txtTelClient.Size = new System.Drawing.Size(100, 20);
            this.txtTelClient.TabIndex = 15;
            this.txtTelClient.TextChanged += new System.EventHandler(this.txtTelClient_TextChanged);
            this.txtTelClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelClient_KeyPress);
            // 
            // gbxCoordonnees
            // 
            this.gbxCoordonnees.Controls.Add(this.rbtPublic);
            this.gbxCoordonnees.Controls.Add(this.rbtPrive);
            this.gbxCoordonnees.Controls.Add(this.txtVille);
            this.gbxCoordonnees.Controls.Add(this.lblCPVille);
            this.gbxCoordonnees.Controls.Add(this.lblNumero);
            this.gbxCoordonnees.Controls.Add(this.txtNumero);
            this.gbxCoordonnees.Controls.Add(this.txtRaison);
            this.gbxCoordonnees.Controls.Add(this.txtTelClient);
            this.gbxCoordonnees.Controls.Add(this.lblRaison);
            this.gbxCoordonnees.Controls.Add(this.txtCP);
            this.gbxCoordonnees.Controls.Add(this.lblType);
            this.gbxCoordonnees.Controls.Add(this.txtAdresse);
            this.gbxCoordonnees.Controls.Add(this.lblDomaine);
            this.gbxCoordonnees.Controls.Add(this.txtDomaine);
            this.gbxCoordonnees.Controls.Add(this.lblAdresse);
            this.gbxCoordonnees.Controls.Add(this.lblTelephone);
            this.gbxCoordonnees.Location = new System.Drawing.Point(12, 12);
            this.gbxCoordonnees.Name = "gbxCoordonnees";
            this.gbxCoordonnees.Size = new System.Drawing.Size(688, 283);
            this.gbxCoordonnees.TabIndex = 18;
            this.gbxCoordonnees.TabStop = false;
            this.gbxCoordonnees.Text = "  Coordonnées";
            // 
            // rbtPublic
            // 
            this.rbtPublic.AutoSize = true;
            this.rbtPublic.Location = new System.Drawing.Point(269, 104);
            this.rbtPublic.Name = "rbtPublic";
            this.rbtPublic.Size = new System.Drawing.Size(54, 17);
            this.rbtPublic.TabIndex = 23;
            this.rbtPublic.TabStop = true;
            this.rbtPublic.Text = "Public";
            this.rbtPublic.UseVisualStyleBackColor = true;
            // 
            // rbtPrive
            // 
            this.rbtPrive.AutoSize = true;
            this.rbtPrive.Location = new System.Drawing.Point(152, 104);
            this.rbtPrive.Name = "rbtPrive";
            this.rbtPrive.Size = new System.Drawing.Size(49, 17);
            this.rbtPrive.TabIndex = 22;
            this.rbtPrive.TabStop = true;
            this.rbtPrive.Text = "Privé";
            this.rbtPrive.UseVisualStyleBackColor = true;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(268, 206);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(274, 20);
            this.txtVille.TabIndex = 21;
            // 
            // lblCPVille
            // 
            this.lblCPVille.AutoSize = true;
            this.lblCPVille.Location = new System.Drawing.Point(44, 209);
            this.lblCPVille.Name = "lblCPVille";
            this.lblCPVille.Size = new System.Drawing.Size(61, 13);
            this.lblCPVille.TabIndex = 19;
            this.lblCPVille.Text = "CP et Ville :";
            // 
            // gbxChiffres
            // 
            this.gbxChiffres.Controls.Add(this.lblErreur);
            this.gbxChiffres.Controls.Add(this.txtEffectif);
            this.gbxChiffres.Controls.Add(this.txtCA);
            this.gbxChiffres.Controls.Add(this.lblEffectif);
            this.gbxChiffres.Controls.Add(this.lblCA);
            this.gbxChiffres.Location = new System.Drawing.Point(13, 314);
            this.gbxChiffres.Name = "gbxChiffres";
            this.gbxChiffres.Size = new System.Drawing.Size(687, 99);
            this.gbxChiffres.TabIndex = 19;
            this.gbxChiffres.TabStop = false;
            this.gbxChiffres.Text = "Client en chiffres";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(323, 63);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(367, 13);
            this.lblErreur.TabIndex = 4;
            this.lblErreur.Text = "Erreur: le CA est erroné, car le CA/employé est > à 1M€uros!!!!!";
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(149, 63);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.Size = new System.Drawing.Size(100, 20);
            this.txtEffectif.TabIndex = 3;
            this.txtEffectif.TextChanged += new System.EventHandler(this.txtEffectif_TextChanged);
            this.txtEffectif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEffectif_KeyPress);
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(149, 29);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(100, 20);
            this.txtCA.TabIndex = 2;
            this.txtCA.TextChanged += new System.EventHandler(this.txtCA_TextChanged);
            this.txtCA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCA_KeyPress);
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(46, 66);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(40, 13);
            this.lblEffectif.TabIndex = 1;
            this.lblEffectif.Text = "Effectif";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(46, 32);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(82, 13);
            this.lblCA.TabIndex = 0;
            this.lblCA.Text = "Chiffre d\'affaires";
            // 
            // gbxNature
            // 
            this.gbxNature.Controls.Add(this.rbtAncienne);
            this.gbxNature.Controls.Add(this.rbtSecondaire);
            this.gbxNature.Controls.Add(this.rbtPrincipale);
            this.gbxNature.Location = new System.Drawing.Point(13, 433);
            this.gbxNature.Name = "gbxNature";
            this.gbxNature.Size = new System.Drawing.Size(687, 55);
            this.gbxNature.TabIndex = 20;
            this.gbxNature.TabStop = false;
            this.gbxNature.Text = "Nature";
            // 
            // rbtAncienne
            // 
            this.rbtAncienne.AutoSize = true;
            this.rbtAncienne.Location = new System.Drawing.Point(373, 20);
            this.rbtAncienne.Name = "rbtAncienne";
            this.rbtAncienne.Size = new System.Drawing.Size(70, 17);
            this.rbtAncienne.TabIndex = 5;
            this.rbtAncienne.TabStop = true;
            this.rbtAncienne.Text = "Ancienne";
            this.rbtAncienne.UseVisualStyleBackColor = true;
            // 
            // rbtSecondaire
            // 
            this.rbtSecondaire.AutoSize = true;
            this.rbtSecondaire.Location = new System.Drawing.Point(250, 19);
            this.rbtSecondaire.Name = "rbtSecondaire";
            this.rbtSecondaire.Size = new System.Drawing.Size(79, 17);
            this.rbtSecondaire.TabIndex = 4;
            this.rbtSecondaire.TabStop = true;
            this.rbtSecondaire.Text = "Secondaire";
            this.rbtSecondaire.UseVisualStyleBackColor = true;
            // 
            // rbtPrincipale
            // 
            this.rbtPrincipale.AutoSize = true;
            this.rbtPrincipale.Location = new System.Drawing.Point(149, 19);
            this.rbtPrincipale.Name = "rbtPrincipale";
            this.rbtPrincipale.Size = new System.Drawing.Size(71, 17);
            this.rbtPrincipale.TabIndex = 3;
            this.rbtPrincipale.TabStop = true;
            this.rbtPrincipale.Text = "Principale";
            this.rbtPrincipale.UseVisualStyleBackColor = true;
            // 
            // gbxContact
            // 
            this.gbxContact.Controls.Add(this.dgvContacts);
            this.gbxContact.Location = new System.Drawing.Point(13, 512);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(690, 106);
            this.gbxContact.TabIndex = 21;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contacts - Intervenants";
            // 
            // dgvContacts
            // 
            this.dgvContacts.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(46, 19);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(601, 70);
            this.dgvContacts.TabIndex = 0;
            // 
            // frmClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 630);
            this.Controls.Add(this.gbxContact);
            this.Controls.Add(this.gbxNature);
            this.Controls.Add(this.gbxChiffres);
            this.Controls.Add(this.gbxCoordonnees);
            this.Name = "frmClie";
            this.Text = "frmClient";
            this.gbxCoordonnees.ResumeLayout(false);
            this.gbxCoordonnees.PerformLayout();
            this.gbxChiffres.ResumeLayout(false);
            this.gbxChiffres.PerformLayout();
            this.gbxNature.ResumeLayout(false);
            this.gbxNature.PerformLayout();
            this.gbxContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRaison;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDomaine;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCPVille;
        private System.Windows.Forms.Label lblEffectif;
        private System.Windows.Forms.Label lblCA;
        protected System.Windows.Forms.TextBox txtNumero;
        protected System.Windows.Forms.TextBox txtRaison;
        protected System.Windows.Forms.TextBox txtDomaine;
        protected System.Windows.Forms.TextBox txtAdresse;
        protected System.Windows.Forms.TextBox txtCP;
        protected System.Windows.Forms.TextBox txtTelClient;
        protected System.Windows.Forms.GroupBox gbxCoordonnees;
        protected System.Windows.Forms.TextBox txtVille;
        protected System.Windows.Forms.GroupBox gbxChiffres;
        protected System.Windows.Forms.TextBox txtEffectif;
        protected System.Windows.Forms.TextBox txtCA;
        protected System.Windows.Forms.GroupBox gbxNature;
        protected System.Windows.Forms.RadioButton rbtPublic;
        protected System.Windows.Forms.RadioButton rbtPrive;
        protected System.Windows.Forms.RadioButton rbtAncienne;
        protected System.Windows.Forms.RadioButton rbtSecondaire;
        protected System.Windows.Forms.RadioButton rbtPrincipale;
        protected System.Windows.Forms.Label lblErreur;
        protected System.Windows.Forms.GroupBox gbxContact;
        protected System.Windows.Forms.DataGridView dgvContacts;
    }
}