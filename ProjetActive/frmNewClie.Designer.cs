namespace ProjetActive
{
    partial class frmNewClie
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxCoordonnees.SuspendLayout();
            this.gbxChiffres.SuspendLayout();
            this.gbxNature.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtRaison
            // 
            this.txtRaison.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtDomaine
            // 
            this.txtDomaine.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtCP
            // 
            this.txtCP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtTelClient
            // 
            this.txtTelClient.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtVille
            // 
            this.txtVille.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtCalcul
            // 
           
            // 
            // txtEffectif
            // 
            this.txtEffectif.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtCA
            // 
            this.txtCA.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(20, 778);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 35);
            this.btnAjouter.TabIndex = 21;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(938, 778);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(112, 35);
            this.btnQuitter.TabIndex = 22;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmNewClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1071, 842);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAjouter);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmNewClie";
            this.Text = "frmNewClient";
            this.Controls.SetChildIndex(this.gbxCoordonnees, 0);
            this.Controls.SetChildIndex(this.gbxChiffres, 0);
            this.Controls.SetChildIndex(this.gbxNature, 0);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.gbxCoordonnees.ResumeLayout(false);
            this.gbxCoordonnees.PerformLayout();
            this.gbxChiffres.ResumeLayout(false);
            this.gbxChiffres.PerformLayout();
            this.gbxNature.ResumeLayout(false);
            this.gbxNature.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnQuitter;
    }
}
