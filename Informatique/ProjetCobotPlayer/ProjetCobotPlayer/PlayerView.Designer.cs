namespace ProjetCobotPlayer
{
    partial class PlayerView
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(147, 86);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(122, 39);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Nouvelle partie";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelConnection
            // 
            this.labelConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConnection.BackColor = System.Drawing.SystemColors.Control;
            this.labelConnection.Enabled = false;
            this.labelConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.ForeColor = System.Drawing.Color.Black;
            this.labelConnection.Location = new System.Drawing.Point(12, 265);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(403, 17);
            this.labelConnection.TabIndex = 1;
            this.labelConnection.Text = "Test en cours...";
            this.labelConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConnection.Click += new System.EventHandler(this.labelConnection_Click);
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 291);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.buttonPlay);
            this.Name = "PlayerView";
            this.Text = "CobotGaming";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelConnection;
    }
}

