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
            this.lblNomRecherche = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.grbProjet = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMotCle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblListeIntervenant = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.grbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblNomRecherche
            // 
            this.lblNomRecherche.AutoSize = true;
            this.lblNomRecherche.Location = new System.Drawing.Point(19, 45);
            this.lblNomRecherche.Name = "lblNomRecherche";
            this.lblNomRecherche.Size = new System.Drawing.Size(90, 13);
            this.lblNomRecherche.TabIndex = 2;
            this.lblNomRecherche.Text = "Par nom de projet";
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
            this.grbProjet.Controls.Add(this.btnOK);
            this.grbProjet.Controls.Add(this.lblMotCle);
            this.grbProjet.Controls.Add(this.textBox1);
            this.grbProjet.Controls.Add(this.btnTous);
            this.grbProjet.Controls.Add(this.btnRechercher);
            this.grbProjet.Controls.Add(this.comboBox1);
            this.grbProjet.Controls.Add(this.lblNomRecherche);
            this.grbProjet.Location = new System.Drawing.Point(25, 23);
            this.grbProjet.Name = "grbProjet";
            this.grbProjet.Size = new System.Drawing.Size(697, 190);
            this.grbProjet.TabIndex = 4;
            this.grbProjet.TabStop = false;
            this.grbProjet.Text = "Recherche ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(549, 42);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblMotCle
            // 
            this.lblMotCle.AutoSize = true;
            this.lblMotCle.Location = new System.Drawing.Point(19, 101);
            this.lblMotCle.Name = "lblMotCle";
            this.lblMotCle.Size = new System.Drawing.Size(60, 13);
            this.lblMotCle.TabIndex = 6;
            this.lblMotCle.Text = "Par mot clé";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(549, 152);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(115, 23);
            this.btnTous.TabIndex = 4;
            this.btnTous.Text = "Afficher TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(549, 96);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(115, 23);
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
            this.lblListeIntervenant.Size = new System.Drawing.Size(264, 20);
            this.lblListeIntervenant.TabIndex = 5;
            this.lblListeIntervenant.Text = "Affichage des intervenants au projet";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(624, 449);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(98, 36);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(25, 449);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 36);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(482, 449);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(92, 36);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(175, 449);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(89, 36);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label lblNomRecherche;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.GroupBox grbProjet;
        private System.Windows.Forms.Label lblListeIntervenant;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMotCle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
    }
}