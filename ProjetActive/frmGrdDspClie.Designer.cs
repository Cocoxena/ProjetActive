namespace ProjetActive
{
    partial class frmGrdDspClie
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
            this.gbxRecherche = new System.Windows.Forms.GroupBox();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtMotCle = new System.Windows.Forms.TextBox();
            this.txtDomaine = new System.Windows.Forms.TextBox();
            this.lblMotCle = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblDomaine = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grdClie = new System.Windows.Forms.DataGridView();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gbxRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClie)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRecherche
            // 
            this.gbxRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRecherche.Controls.Add(this.btnTous);
            this.gbxRecherche.Controls.Add(this.btnRechercher);
            this.gbxRecherche.Controls.Add(this.txtMotCle);
            this.gbxRecherche.Controls.Add(this.txtDomaine);
            this.gbxRecherche.Controls.Add(this.lblMotCle);
            this.gbxRecherche.Controls.Add(this.txtNom);
            this.gbxRecherche.Controls.Add(this.lblDomaine);
            this.gbxRecherche.Controls.Add(this.lblNom);
            this.gbxRecherche.Location = new System.Drawing.Point(28, 53);
            this.gbxRecherche.Name = "gbxRecherche";
            this.gbxRecherche.Size = new System.Drawing.Size(1244, 203);
            this.gbxRecherche.TabIndex = 0;
            this.gbxRecherche.TabStop = false;
            this.gbxRecherche.Text = "Recherche";
            // 
            // btnTous
            // 
            this.btnTous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTous.Location = new System.Drawing.Point(1142, 144);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(92, 29);
            this.btnTous.TabIndex = 8;
            this.btnTous.Text = "Afficher TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRechercher.Location = new System.Drawing.Point(1031, 143);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(92, 30);
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtMotCle
            // 
            this.txtMotCle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotCle.Location = new System.Drawing.Point(158, 102);
            this.txtMotCle.Name = "txtMotCle";
            this.txtMotCle.Size = new System.Drawing.Size(965, 20);
            this.txtMotCle.TabIndex = 5;
            // 
            // txtDomaine
            // 
            this.txtDomaine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomaine.Location = new System.Drawing.Point(158, 65);
            this.txtDomaine.Name = "txtDomaine";
            this.txtDomaine.Size = new System.Drawing.Size(965, 20);
            this.txtDomaine.TabIndex = 4;
            // 
            // lblMotCle
            // 
            this.lblMotCle.AutoSize = true;
            this.lblMotCle.Location = new System.Drawing.Point(22, 105);
            this.lblMotCle.Name = "lblMotCle";
            this.lblMotCle.Size = new System.Drawing.Size(65, 13);
            this.lblMotCle.TabIndex = 3;
            this.lblMotCle.Text = "par mot clé :";
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(158, 28);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(965, 20);
            this.txtNom.TabIndex = 2;
            // 
            // lblDomaine
            // 
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Location = new System.Drawing.Point(22, 68);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(71, 13);
            this.lblDomaine.TabIndex = 1;
            this.lblDomaine.Text = "par domaine :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 31);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(94, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "par nom du client :";
            // 
            // grdClie
            // 
            this.grdClie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClie.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClie.Location = new System.Drawing.Point(26, 273);
            this.grdClie.Name = "grdClie";
            this.grdClie.Size = new System.Drawing.Size(1246, 216);
            this.grdClie.TabIndex = 1;
            this.grdClie.DoubleClick += new System.EventHandler(this.grdClie_DoubleClick);
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichage.Location = new System.Drawing.Point(25, 244);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(156, 20);
            this.lblAffichage.TabIndex = 2;
            this.lblAffichage.Text = "Affichage des clients";
            this.lblAffichage.Visible = false;
            this.lblAffichage.Click += new System.EventHandler(this.lblAffichage_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjouter.Location = new System.Drawing.Point(28, 502);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(101, 32);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.Location = new System.Drawing.Point(1168, 502);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(107, 32);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Location = new System.Drawing.Point(1013, 502);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(93, 32);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifier.Location = new System.Drawing.Point(177, 502);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(97, 32);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // frmGrdDspClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 552);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.grdClie);
            this.Controls.Add(this.gbxRecherche);
            this.Name = "frmGrdDspClie";
            this.Text = "frmGrdDspClients";
            this.DoubleClick += new System.EventHandler(this.frmGrdDspClie_DoubleClick);
            this.gbxRecherche.ResumeLayout(false);
            this.gbxRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRecherche;
        private System.Windows.Forms.TextBox txtMotCle;
        private System.Windows.Forms.TextBox txtDomaine;
        private System.Windows.Forms.Label lblMotCle;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblDomaine;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DataGridView grdClie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        protected System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
    }
}