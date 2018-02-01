namespace ProjetActive
{
    partial class frmGrdDspInte
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNomProjetRecherche = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.grbProjet = new System.Windows.Forms.GroupBox();
            this.lblMotCle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblListeIntervenant = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblNomContactRecherche = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.grbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(424, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblNomProjetRecherche
            // 
            this.lblNomProjetRecherche.AutoSize = true;
            this.lblNomProjetRecherche.Location = new System.Drawing.Point(19, 37);
            this.lblNomProjetRecherche.Name = "lblNomProjetRecherche";
            this.lblNomProjetRecherche.Size = new System.Drawing.Size(90, 13);
            this.lblNomProjetRecherche.TabIndex = 2;
            this.lblNomProjetRecherche.Text = "Par nom de projet";
            // 
            // dgvListe
            // 
            this.dgvListe.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(25, 272);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(697, 154);
            this.dgvListe.TabIndex = 3;
            // 
            // grbProjet
            // 
            this.grbProjet.Controls.Add(this.textBox2);
            this.grbProjet.Controls.Add(this.lblNomContactRecherche);
            this.grbProjet.Controls.Add(this.lblMotCle);
            this.grbProjet.Controls.Add(this.textBox1);
            this.grbProjet.Controls.Add(this.btnTous);
            this.grbProjet.Controls.Add(this.btnRechercher);
            this.grbProjet.Controls.Add(this.comboBox1);
            this.grbProjet.Controls.Add(this.lblNomProjetRecherche);
            this.grbProjet.Location = new System.Drawing.Point(25, 23);
            this.grbProjet.Name = "grbProjet";
            this.grbProjet.Size = new System.Drawing.Size(697, 190);
            this.grbProjet.TabIndex = 4;
            this.grbProjet.TabStop = false;
            this.grbProjet.Text = "Recherche ";
            // 
            // lblMotCle
            // 
            this.lblMotCle.AutoSize = true;
            this.lblMotCle.Location = new System.Drawing.Point(19, 116);
            this.lblMotCle.Name = "lblMotCle";
            this.lblMotCle.Size = new System.Drawing.Size(60, 13);
            this.lblMotCle.TabIndex = 6;
            this.lblMotCle.Text = "Par mot clé";
            this.lblMotCle.Click += new System.EventHandler(this.lblMotCle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(581, 152);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(86, 23);
            this.btnTous.TabIndex = 4;
            this.btnTous.Text = "Afficher TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(457, 152);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(92, 23);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // lblListeIntervenant
            // 
            this.lblListeIntervenant.AutoSize = true;
            this.lblListeIntervenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeIntervenant.Location = new System.Drawing.Point(21, 239);
            this.lblListeIntervenant.Name = "lblListeIntervenant";
            this.lblListeIntervenant.Size = new System.Drawing.Size(198, 20);
            this.lblListeIntervenant.TabIndex = 5;
            this.lblListeIntervenant.Text = "Affichage des intervenants";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(624, 449);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(98, 27);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(25, 449);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 27);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(482, 449);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(92, 27);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(175, 449);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(89, 27);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // lblNomContactRecherche
            // 
            this.lblNomContactRecherche.AutoSize = true;
            this.lblNomContactRecherche.Location = new System.Drawing.Point(19, 78);
            this.lblNomContactRecherche.Name = "lblNomContactRecherche";
            this.lblNomContactRecherche.Size = new System.Drawing.Size(100, 13);
            this.lblNomContactRecherche.TabIndex = 8;
            this.lblNomContactRecherche.Text = "Par nom de contact";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(424, 20);
            this.textBox2.TabIndex = 9;
            // 
            // frmGrdDspInte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 497);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblListeIntervenant);
            this.Controls.Add(this.grbProjet);
            this.Controls.Add(this.dgvListe);
            this.Name = "frmGrdDspInte";
            this.Text = "frmGrdDspIntervenant";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.grbProjet.ResumeLayout(false);
            this.grbProjet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNomProjetRecherche;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.GroupBox grbProjet;
        private System.Windows.Forms.Label lblListeIntervenant;
        private System.Windows.Forms.Label lblMotCle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        protected System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.Label lblNomContactRecherche;
    }
}