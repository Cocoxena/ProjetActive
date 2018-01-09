namespace ProjetActive
{
    partial class frmInte
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
            this.gbxCoordonnees = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbxIntervention = new System.Windows.Forms.GroupBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblFonction = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbHeures = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProjet = new System.Windows.Forms.Label();
            this.txtProjetCode = new System.Windows.Forms.TextBox();
            this.lblProjetNom = new System.Windows.Forms.Label();
            this.txtProjetNom = new System.Windows.Forms.TextBox();
            this.gbxCoordonnees.SuspendLayout();
            this.gbxIntervention.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCoordonnees
            // 
            this.gbxCoordonnees.Controls.Add(this.textBox3);
            this.gbxCoordonnees.Controls.Add(this.lblTelephone);
            this.gbxCoordonnees.Controls.Add(this.textBox2);
            this.gbxCoordonnees.Controls.Add(this.txtNom);
            this.gbxCoordonnees.Controls.Add(this.lblPrenom);
            this.gbxCoordonnees.Controls.Add(this.lblNom);
            this.gbxCoordonnees.Location = new System.Drawing.Point(23, 22);
            this.gbxCoordonnees.Name = "gbxCoordonnees";
            this.gbxCoordonnees.Size = new System.Drawing.Size(560, 127);
            this.gbxCoordonnees.TabIndex = 0;
            this.gbxCoordonnees.TabStop = false;
            this.gbxCoordonnees.Text = "Coordonnées";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(21, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(21, 56);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(95, 23);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(212, 20);
            this.txtNom.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(21, 89);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 5;
            // 
            // gbxIntervention
            // 
            this.gbxIntervention.Controls.Add(this.txtProjetNom);
            this.gbxIntervention.Controls.Add(this.lblProjetNom);
            this.gbxIntervention.Controls.Add(this.txtProjetCode);
            this.gbxIntervention.Controls.Add(this.lblProjet);
            this.gbxIntervention.Controls.Add(this.textBox1);
            this.gbxIntervention.Controls.Add(this.lbHeures);
            this.gbxIntervention.Controls.Add(this.textBox5);
            this.gbxIntervention.Controls.Add(this.lblFonction);
            this.gbxIntervention.Controls.Add(this.txtClient);
            this.gbxIntervention.Controls.Add(this.lblClient);
            this.gbxIntervention.Location = new System.Drawing.Point(23, 171);
            this.gbxIntervention.Name = "gbxIntervention";
            this.gbxIntervention.Size = new System.Drawing.Size(560, 236);
            this.gbxIntervention.TabIndex = 1;
            this.gbxIntervention.TabStop = false;
            this.gbxIntervention.Text = "Interventions";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(21, 32);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client :";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(95, 29);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(212, 20);
            this.txtClient.TabIndex = 1;
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(21, 155);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(57, 13);
            this.lblFonction.TabIndex = 2;
            this.lblFonction.Text = "Fonction : ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 20);
            this.textBox5.TabIndex = 3;
            // 
            // lbHeures
            // 
            this.lbHeures.AutoSize = true;
            this.lbHeures.Location = new System.Drawing.Point(21, 198);
            this.lbHeures.Name = "lbHeures";
            this.lbHeures.Size = new System.Drawing.Size(57, 13);
            this.lbHeures.TabIndex = 4;
            this.lbHeures.Text = "Durée (h) :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblProjet
            // 
            this.lblProjet.AutoSize = true;
            this.lblProjet.Location = new System.Drawing.Point(20, 113);
            this.lblProjet.Name = "lblProjet";
            this.lblProjet.Size = new System.Drawing.Size(73, 13);
            this.lblProjet.TabIndex = 6;
            this.lblProjet.Text = "Projet (code) :";
            // 
            // txtProjetCode
            // 
            this.txtProjetCode.Location = new System.Drawing.Point(95, 110);
            this.txtProjetCode.Name = "txtProjetCode";
            this.txtProjetCode.Size = new System.Drawing.Size(212, 20);
            this.txtProjetCode.TabIndex = 7;
            // 
            // lblProjetNom
            // 
            this.lblProjetNom.AutoSize = true;
            this.lblProjetNom.Location = new System.Drawing.Point(20, 72);
            this.lblProjetNom.Name = "lblProjetNom";
            this.lblProjetNom.Size = new System.Drawing.Size(69, 13);
            this.lblProjetNom.TabIndex = 8;
            this.lblProjetNom.Text = "Projet (nom) :";
            // 
            // txtProjetNom
            // 
            this.txtProjetNom.Location = new System.Drawing.Point(95, 69);
            this.txtProjetNom.Name = "txtProjetNom";
            this.txtProjetNom.Size = new System.Drawing.Size(212, 20);
            this.txtProjetNom.TabIndex = 9;
            // 
            // frmIntervenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 431);
            this.Controls.Add(this.gbxIntervention);
            this.Controls.Add(this.gbxCoordonnees);
            this.Name = "frmIntervenant";
            this.Text = "frmIntervenant";
            this.gbxCoordonnees.ResumeLayout(false);
            this.gbxCoordonnees.PerformLayout();
            this.gbxIntervention.ResumeLayout(false);
            this.gbxIntervention.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lbHeures;
        private System.Windows.Forms.Label lblProjet;
        private System.Windows.Forms.Label lblProjetNom;
        protected System.Windows.Forms.GroupBox gbxCoordonnees;
        protected System.Windows.Forms.TextBox textBox3;
        protected System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.TextBox txtNom;
        protected System.Windows.Forms.GroupBox gbxIntervention;
        protected System.Windows.Forms.TextBox textBox5;
        protected System.Windows.Forms.TextBox txtClient;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.TextBox txtProjetCode;
        protected System.Windows.Forms.TextBox txtProjetNom;
    }
}