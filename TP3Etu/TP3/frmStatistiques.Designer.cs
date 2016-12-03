namespace TP3
{
	partial class frmStatistiques
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
			this.components = new System.ComponentModel.Container();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblCarréNombre = new System.Windows.Forms.Label();
			this.lblLigneNombre = new System.Windows.Forms.Label();
			this.lblTNombre = new System.Windows.Forms.Label();
			this.lblLNombre = new System.Windows.Forms.Label();
			this.lblJNombre = new System.Windows.Forms.Label();
			this.lblSNombre = new System.Windows.Forms.Label();
			this.lblZNombre = new System.Windows.Forms.Label();
			this.lblZPourcentage = new System.Windows.Forms.Label();
			this.lblSPourcentage = new System.Windows.Forms.Label();
			this.lblJPourcentage = new System.Windows.Forms.Label();
			this.lblLPourcentage = new System.Windows.Forms.Label();
			this.lblTPourcentage = new System.Windows.Forms.Label();
			this.lblLignePourcentage = new System.Windows.Forms.Label();
			this.lblCarréPourcentage = new System.Windows.Forms.Label();
			this.btnFermer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTemps = new System.Windows.Forms.Label();
			this.timerTemps = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Carré :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ligne :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "T :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "L :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 117);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "J :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 138);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "S :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 159);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(20, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Z :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblZNombre);
			this.groupBox1.Controls.Add(this.lblSNombre);
			this.groupBox1.Controls.Add(this.lblJNombre);
			this.groupBox1.Controls.Add(this.lblLNombre);
			this.groupBox1.Controls.Add(this.lblTNombre);
			this.groupBox1.Controls.Add(this.lblLigneNombre);
			this.groupBox1.Controls.Add(this.lblCarréNombre);
			this.groupBox1.Location = new System.Drawing.Point(57, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(140, 168);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nombre de pièces";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblZPourcentage);
			this.groupBox2.Controls.Add(this.lblTPourcentage);
			this.groupBox2.Controls.Add(this.lblSPourcentage);
			this.groupBox2.Controls.Add(this.lblCarréPourcentage);
			this.groupBox2.Controls.Add(this.lblJPourcentage);
			this.groupBox2.Controls.Add(this.lblLignePourcentage);
			this.groupBox2.Controls.Add(this.lblLPourcentage);
			this.groupBox2.Location = new System.Drawing.Point(219, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(138, 168);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pourcentage";
			// 
			// lblCarréNombre
			// 
			this.lblCarréNombre.AutoSize = true;
			this.lblCarréNombre.Location = new System.Drawing.Point(6, 21);
			this.lblCarréNombre.Name = "lblCarréNombre";
			this.lblCarréNombre.Size = new System.Drawing.Size(35, 13);
			this.lblCarréNombre.TabIndex = 0;
			this.lblCarréNombre.Text = "label1";
			// 
			// lblLigneNombre
			// 
			this.lblLigneNombre.AutoSize = true;
			this.lblLigneNombre.Location = new System.Drawing.Point(6, 42);
			this.lblLigneNombre.Name = "lblLigneNombre";
			this.lblLigneNombre.Size = new System.Drawing.Size(35, 13);
			this.lblLigneNombre.TabIndex = 1;
			this.lblLigneNombre.Text = "label2";
			// 
			// lblTNombre
			// 
			this.lblTNombre.AutoSize = true;
			this.lblTNombre.Location = new System.Drawing.Point(6, 63);
			this.lblTNombre.Name = "lblTNombre";
			this.lblTNombre.Size = new System.Drawing.Size(41, 13);
			this.lblTNombre.TabIndex = 2;
			this.lblTNombre.Text = "label10";
			// 
			// lblLNombre
			// 
			this.lblLNombre.AutoSize = true;
			this.lblLNombre.Location = new System.Drawing.Point(6, 84);
			this.lblLNombre.Name = "lblLNombre";
			this.lblLNombre.Size = new System.Drawing.Size(41, 13);
			this.lblLNombre.TabIndex = 3;
			this.lblLNombre.Text = "label11";
			// 
			// lblJNombre
			// 
			this.lblJNombre.AutoSize = true;
			this.lblJNombre.Location = new System.Drawing.Point(6, 105);
			this.lblJNombre.Name = "lblJNombre";
			this.lblJNombre.Size = new System.Drawing.Size(41, 13);
			this.lblJNombre.TabIndex = 4;
			this.lblJNombre.Text = "label12";
			// 
			// lblSNombre
			// 
			this.lblSNombre.AutoSize = true;
			this.lblSNombre.Location = new System.Drawing.Point(6, 126);
			this.lblSNombre.Name = "lblSNombre";
			this.lblSNombre.Size = new System.Drawing.Size(41, 13);
			this.lblSNombre.TabIndex = 5;
			this.lblSNombre.Text = "label13";
			// 
			// lblZNombre
			// 
			this.lblZNombre.AutoSize = true;
			this.lblZNombre.Location = new System.Drawing.Point(6, 147);
			this.lblZNombre.Name = "lblZNombre";
			this.lblZNombre.Size = new System.Drawing.Size(41, 13);
			this.lblZNombre.TabIndex = 6;
			this.lblZNombre.Text = "label14";
			// 
			// lblZPourcentage
			// 
			this.lblZPourcentage.AutoSize = true;
			this.lblZPourcentage.Location = new System.Drawing.Point(6, 147);
			this.lblZPourcentage.Name = "lblZPourcentage";
			this.lblZPourcentage.Size = new System.Drawing.Size(41, 13);
			this.lblZPourcentage.TabIndex = 13;
			this.lblZPourcentage.Text = "label14";
			// 
			// lblSPourcentage
			// 
			this.lblSPourcentage.AutoSize = true;
			this.lblSPourcentage.Location = new System.Drawing.Point(6, 126);
			this.lblSPourcentage.Name = "lblSPourcentage";
			this.lblSPourcentage.Size = new System.Drawing.Size(41, 13);
			this.lblSPourcentage.TabIndex = 12;
			this.lblSPourcentage.Text = "label13";
			// 
			// lblJPourcentage
			// 
			this.lblJPourcentage.AutoSize = true;
			this.lblJPourcentage.Location = new System.Drawing.Point(6, 105);
			this.lblJPourcentage.Name = "lblJPourcentage";
			this.lblJPourcentage.Size = new System.Drawing.Size(41, 13);
			this.lblJPourcentage.TabIndex = 11;
			this.lblJPourcentage.Text = "label12";
			// 
			// lblLPourcentage
			// 
			this.lblLPourcentage.AutoSize = true;
			this.lblLPourcentage.Location = new System.Drawing.Point(6, 84);
			this.lblLPourcentage.Name = "lblLPourcentage";
			this.lblLPourcentage.Size = new System.Drawing.Size(41, 13);
			this.lblLPourcentage.TabIndex = 10;
			this.lblLPourcentage.Text = "label11";
			// 
			// lblTPourcentage
			// 
			this.lblTPourcentage.AutoSize = true;
			this.lblTPourcentage.Location = new System.Drawing.Point(6, 63);
			this.lblTPourcentage.Name = "lblTPourcentage";
			this.lblTPourcentage.Size = new System.Drawing.Size(41, 13);
			this.lblTPourcentage.TabIndex = 9;
			this.lblTPourcentage.Text = "label10";
			// 
			// lblLignePourcentage
			// 
			this.lblLignePourcentage.AutoSize = true;
			this.lblLignePourcentage.Location = new System.Drawing.Point(6, 42);
			this.lblLignePourcentage.Name = "lblLignePourcentage";
			this.lblLignePourcentage.Size = new System.Drawing.Size(35, 13);
			this.lblLignePourcentage.TabIndex = 8;
			this.lblLignePourcentage.Text = "label2";
			// 
			// lblCarréPourcentage
			// 
			this.lblCarréPourcentage.AutoSize = true;
			this.lblCarréPourcentage.Location = new System.Drawing.Point(6, 21);
			this.lblCarréPourcentage.Name = "lblCarréPourcentage";
			this.lblCarréPourcentage.Size = new System.Drawing.Size(35, 13);
			this.lblCarréPourcentage.TabIndex = 7;
			this.lblCarréPourcentage.Text = "label1";
			// 
			// btnFermer
			// 
			this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnFermer.Location = new System.Drawing.Point(155, 271);
			this.btnFermer.Name = "btnFermer";
			this.btnFermer.Size = new System.Drawing.Size(75, 23);
			this.btnFermer.TabIndex = 11;
			this.btnFermer.Text = "Fermer";
			this.btnFermer.UseVisualStyleBackColor = true;
			this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 198);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Score :";
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(54, 198);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(35, 13);
			this.lblScore.TabIndex = 13;
			this.lblScore.Text = "label2";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Temps de jeu :";
			// 
			// lblTemps
			// 
			this.lblTemps.AutoSize = true;
			this.lblTemps.Location = new System.Drawing.Point(95, 220);
			this.lblTemps.Name = "lblTemps";
			this.lblTemps.Size = new System.Drawing.Size(41, 13);
			this.lblTemps.TabIndex = 15;
			this.lblTemps.Text = "label10";
			// 
			// timerTemps
			// 
			this.timerTemps.Interval = 1000;
			// 
			// frmStatistiques
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 306);
			this.ControlBox = false;
			this.Controls.Add(this.lblTemps);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFermer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Name = "frmStatistiques";
			this.Text = "Statistiques du jeu";
			this.Load += new System.EventHandler(this.frmStatistiques_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblZNombre;
		private System.Windows.Forms.Label lblSNombre;
		private System.Windows.Forms.Label lblJNombre;
		private System.Windows.Forms.Label lblLNombre;
		private System.Windows.Forms.Label lblTNombre;
		private System.Windows.Forms.Label lblLigneNombre;
		private System.Windows.Forms.Label lblCarréNombre;
		private System.Windows.Forms.Label lblZPourcentage;
		private System.Windows.Forms.Label lblTPourcentage;
		private System.Windows.Forms.Label lblSPourcentage;
		private System.Windows.Forms.Label lblCarréPourcentage;
		private System.Windows.Forms.Label lblJPourcentage;
		private System.Windows.Forms.Label lblLignePourcentage;
		private System.Windows.Forms.Label lblLPourcentage;
		private System.Windows.Forms.Button btnFermer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTemps;
		private System.Windows.Forms.Timer timerTemps;
	}
}