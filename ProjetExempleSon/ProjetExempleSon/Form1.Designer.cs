namespace ProjetExempleSon
{
  partial class Form1
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
      this.btnPlaySound = new System.Windows.Forms.Button();
      this.btnStopSound = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnPlaySound
      // 
      this.btnPlaySound.Location = new System.Drawing.Point(106, 33);
      this.btnPlaySound.Name = "btnPlaySound";
      this.btnPlaySound.Size = new System.Drawing.Size(122, 23);
      this.btnPlaySound.TabIndex = 0;
      this.btnPlaySound.Text = "Jouer un son";
      this.btnPlaySound.UseVisualStyleBackColor = true;
      this.btnPlaySound.Click += new System.EventHandler(this.btnPlaySound_Click);
      // 
      // btnStopSound
      // 
      this.btnStopSound.Location = new System.Drawing.Point(106, 78);
      this.btnStopSound.Name = "btnStopSound";
      this.btnStopSound.Size = new System.Drawing.Size(122, 23);
      this.btnStopSound.TabIndex = 0;
      this.btnStopSound.Text = "Arrêter le son";
      this.btnStopSound.UseVisualStyleBackColor = true;
      this.btnStopSound.Click += new System.EventHandler(this.btnStopSound_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(331, 136);
      this.Controls.Add(this.btnStopSound);
      this.Controls.Add(this.btnPlaySound);
      this.Name = "Form1";
      this.Text = "Projet exemple pour jouer un son";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnPlaySound;
    private System.Windows.Forms.Button btnStopSound;
  }
}

