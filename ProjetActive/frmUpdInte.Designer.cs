namespace ProjetActive
{
    partial class frmUpdInte
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
            this.Enregistrer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxCoordonnees.SuspendLayout();
            this.gbxIntervention.SuspendLayout();
            this.gbxIdContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(27, 561);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(85, 30);
            this.Enregistrer.TabIndex = 2;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(504, 561);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(79, 30);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmUpdInte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(610, 603);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.Enregistrer);
            this.Name = "frmUpdInte";
            this.Text = "frmUpdIntervenant";
            this.Controls.SetChildIndex(this.gbxIdContact, 0);
            this.Controls.SetChildIndex(this.gbxCoordonnees, 0);
            this.Controls.SetChildIndex(this.gbxIntervention, 0);
            this.Controls.SetChildIndex(this.Enregistrer, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.gbxCoordonnees.ResumeLayout(false);
            this.gbxCoordonnees.PerformLayout();
            this.gbxIntervention.ResumeLayout(false);
            this.gbxIntervention.PerformLayout();
            this.gbxIdContact.ResumeLayout(false);
            this.gbxIdContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button btnQuitter;
    }
}
