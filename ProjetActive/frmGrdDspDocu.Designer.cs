namespace ProjetActive
{
    partial class frmGrdDspDocu
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
            this.grbRecherche = new System.Windows.Forms.GroupBox();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMotCle = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNomRecherche = new System.Windows.Forms.Label();
            this.grdDocu = new System.Windows.Forms.DataGridView();
            this.lblListe = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grbRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocu)).BeginInit();
            this.SuspendLayout();
            // 
            // grbRecherche
            // 
            this.grbRecherche.Controls.Add(this.btnTous);
            this.grbRecherche.Controls.Add(this.btnRechercher);
            this.grbRecherche.Controls.Add(this.textBox1);
            this.grbRecherche.Controls.Add(this.lblMotCle);
            this.grbRecherche.Controls.Add(this.btnOK);
            this.grbRecherche.Controls.Add(this.comboBox1);
            this.grbRecherche.Controls.Add(this.lblNomRecherche);
            this.grbRecherche.Location = new System.Drawing.Point(26, 26);
            this.grbRecherche.Name = "grbRecherche";
            this.grbRecherche.Size = new System.Drawing.Size(680, 156);
            this.grbRecherche.TabIndex = 0;
            this.grbRecherche.TabStop = false;
            this.grbRecherche.Text = "Recherche";
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(542, 116);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(106, 23);
            this.btnTous.TabIndex = 6;
            this.btnTous.Text = "Afficher TOUS";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(542, 75);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(106, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblMotCle
            // 
            this.lblMotCle.AutoSize = true;
            this.lblMotCle.Location = new System.Drawing.Point(25, 78);
            this.lblMotCle.Name = "lblMotCle";
            this.lblMotCle.Size = new System.Drawing.Size(60, 13);
            this.lblMotCle.TabIndex = 3;
            this.lblMotCle.Text = "Par mot clé";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(542, 35);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblNomRecherche
            // 
            this.lblNomRecherche.AutoSize = true;
            this.lblNomRecherche.Location = new System.Drawing.Point(25, 38);
            this.lblNomRecherche.Name = "lblNomRecherche";
            this.lblNomRecherche.Size = new System.Drawing.Size(89, 13);
            this.lblNomRecherche.TabIndex = 0;
            this.lblNomRecherche.Text = "Par nom du client";
            // 
            // grdDocu
            // 
            this.grdDocu.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdDocu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocu.Location = new System.Drawing.Point(26, 229);
            this.grdDocu.Name = "grdDocu";
            this.grdDocu.Size = new System.Drawing.Size(680, 171);
            this.grdDocu.TabIndex = 1;
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListe.Location = new System.Drawing.Point(23, 204);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(319, 20);
            this.lblListe.TabIndex = 2;
            this.lblListe.Text = "Affichage des documents associés au client";
            this.lblListe.Click += new System.EventHandler(this.lblListe_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(610, 416);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(96, 37);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(26, 416);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(93, 37);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(454, 416);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 37);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(158, 416);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(99, 37);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // frmGrdDspDocu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 472);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.grdDocu);
            this.Controls.Add(this.grbRecherche);
            this.Name = "frmGrdDspDocu";
            this.Text = "frmGrdDspDocumentation";
            this.grbRecherche.ResumeLayout(false);
            this.grbRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRecherche;
        private System.Windows.Forms.Label lblNomRecherche;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView grdDocu;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMotCle;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
    }
}