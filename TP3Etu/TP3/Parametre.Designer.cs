namespace TP3
{
    partial class Parametre
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
            this.lblColonne = new System.Windows.Forms.Label();
            this.lblLignes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColonne
            // 
            this.lblColonne.AutoSize = true;
            this.lblColonne.Location = new System.Drawing.Point(12, 19);
            this.lblColonne.Name = "lblColonne";
            this.lblColonne.Size = new System.Drawing.Size(108, 13);
            this.lblColonne.TabIndex = 0;
            this.lblColonne.Text = "Nombre de colonnes:";
            // 
            // lblLignes
            // 
            this.lblLignes.AutoSize = true;
            this.lblLignes.Location = new System.Drawing.Point(12, 49);
            this.lblLignes.Name = "lblLignes";
            this.lblLignes.Size = new System.Drawing.Size(92, 13);
            this.lblLignes.TabIndex = 1;
            this.lblLignes.Text = "Nombre de lignes:";
            // 
            // Parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblLignes);
            this.Controls.Add(this.lblColonne);
            this.Name = "Parametre";
            this.Text = "Paramètre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColonne;
        private System.Windows.Forms.Label lblLignes;
    }
}