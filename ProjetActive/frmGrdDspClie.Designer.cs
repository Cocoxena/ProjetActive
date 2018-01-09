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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblMotCle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.gbxRecherche.Controls.Add(this.btnTous);
            this.gbxRecherche.Controls.Add(this.btnRechercher);
            this.gbxRecherche.Controls.Add(this.textBox3);
            this.gbxRecherche.Controls.Add(this.textBox2);
            this.gbxRecherche.Controls.Add(this.lblMotCle);
            this.gbxRecherche.Controls.Add(this.textBox1);
            this.gbxRecherche.Controls.Add(this.lblDomaine);
            this.gbxRecherche.Controls.Add(this.lblNom);
            this.gbxRecherche.Location = new System.Drawing.Point(28, 33);
            this.gbxRecherche.Name = "gbxRecherche";
            this.gbxRecherche.Size = new System.Drawing.Size(764, 189);
            this.gbxRecherche.TabIndex = 0;
            this.gbxRecherche.TabStop = false;
            this.gbxRecherche.Text = "Recherche";
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(644, 141);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(92, 29);
            this.btnTous.TabIndex = 8;
            this.btnTous.Text = "Afficher TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(463, 141);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(92, 29);
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(397, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 20);
            this.textBox2.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 20);
            this.textBox1.TabIndex = 2;
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
            this.grdClie.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClie.Location = new System.Drawing.Point(28, 273);
            this.grdClie.Name = "grdClie";
            this.grdClie.Size = new System.Drawing.Size(764, 146);
            this.grdClie.TabIndex = 1;
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
            this.btnAjouter.Location = new System.Drawing.Point(28, 435);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(101, 32);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(685, 435);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(107, 32);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(530, 435);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(93, 32);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(177, 435);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(97, 32);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // frmGrdDspClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 494);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblMotCle;
        private System.Windows.Forms.TextBox textBox1;
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