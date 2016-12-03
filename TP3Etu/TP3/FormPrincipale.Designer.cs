namespace TP3
{
  partial class FormPrincipale
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent( )
    {
			this.components = new System.ComponentModel.Container();
			this.tableauJeu = new System.Windows.Forms.TableLayoutPanel();
			this.lblTextScore = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.gbSuivant = new System.Windows.Forms.GroupBox();
			this.timerBlocDescente = new System.Windows.Forms.Timer(this.components);
			this.btnParametres = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recommencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableauJeu
			// 
			this.tableauJeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tableauJeu.ColumnCount = 20;
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.63538F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.220217F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.01805F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableauJeu.Location = new System.Drawing.Point(9, 33);
			this.tableauJeu.Margin = new System.Windows.Forms.Padding(0);
			this.tableauJeu.Name = "tableauJeu";
			this.tableauJeu.RowCount = 30;
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.628941F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.350646F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.001134F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableauJeu.Size = new System.Drawing.Size(222, 441);
			this.tableauJeu.TabIndex = 1;
			// 
			// lblTextScore
			// 
			this.lblTextScore.AutoSize = true;
			this.lblTextScore.Location = new System.Drawing.Point(237, 174);
			this.lblTextScore.Name = "lblTextScore";
			this.lblTextScore.Size = new System.Drawing.Size(41, 13);
			this.lblTextScore.TabIndex = 3;
			this.lblTextScore.Text = "Score :";
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(284, 174);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(13, 13);
			this.lblScore.TabIndex = 4;
			this.lblScore.Text = "0";
			// 
			// gbSuivant
			// 
			this.gbSuivant.Location = new System.Drawing.Point(240, 33);
			this.gbSuivant.Name = "gbSuivant";
			this.gbSuivant.Size = new System.Drawing.Size(200, 110);
			this.gbSuivant.TabIndex = 2;
			this.gbSuivant.TabStop = false;
			this.gbSuivant.Text = "Pièce suivante";
			// 
			// timerBlocDescente
			// 
			this.timerBlocDescente.Interval = 1000;
			this.timerBlocDescente.Tick += new System.EventHandler(this.timerBlocDescente_Tick);
			// 
			// btnParametres
			// 
			this.btnParametres.Location = new System.Drawing.Point(348, 174);
			this.btnParametres.Name = "btnParametres";
			this.btnParametres.Size = new System.Drawing.Size(75, 23);
			this.btnParametres.TabIndex = 5;
			this.btnParametres.Text = "Paramètres";
			this.btnParametres.UseVisualStyleBackColor = true;
			this.btnParametres.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnParametres_MouseClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(452, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// jeuToolStripMenuItem
			// 
			this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recommencerToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
			this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
			this.jeuToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
			this.jeuToolStripMenuItem.Text = "Jeu";
			// 
			// recommencerToolStripMenuItem
			// 
			this.recommencerToolStripMenuItem.Name = "recommencerToolStripMenuItem";
			this.recommencerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.recommencerToolStripMenuItem.Text = "Recommencer";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.quitterToolStripMenuItem.Text = "Quitter";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// paramètresToolStripMenuItem
			// 
			this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
			this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.paramètresToolStripMenuItem.Text = "Paramètres";
			// 
			// statistiquesToolStripMenuItem
			// 
			this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
			this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.statistiquesToolStripMenuItem.Text = "Statistiques";
			// 
			// FormPrincipale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 483);
			this.Controls.Add(this.btnParametres);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.lblTextScore);
			this.Controls.Add(this.gbSuivant);
			this.Controls.Add(this.tableauJeu);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "FormPrincipale";
			this.Text = "Titris";
			this.Load += new System.EventHandler(this.frmLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableauJeu;
		private System.Windows.Forms.GroupBox gbSuivant;
		private System.Windows.Forms.Label lblTextScore;
		private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerBlocDescente;
        private System.Windows.Forms.Button btnParametres;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recommencerToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
	}
}

