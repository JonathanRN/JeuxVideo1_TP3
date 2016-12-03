namespace Son
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnChoisirSon = new System.Windows.Forms.Button();
			this.tbSon = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbBoucle = new System.Windows.Forms.CheckBox();
			this.btnArreter = new System.Windows.Forms.Button();
			this.btnJouer = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblVolume = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
			this.groupBox1.Controls.Add(this.btnChoisirSon);
			this.groupBox1.Controls.Add(this.tbSon);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(524, 61);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Identification du son";
			// 
			// btnChoisirSon
			// 
			this.btnChoisirSon.Location = new System.Drawing.Point(473, 19);
			this.btnChoisirSon.Name = "btnChoisirSon";
			this.btnChoisirSon.Size = new System.Drawing.Size(43, 28);
			this.btnChoisirSon.TabIndex = 1;
			this.btnChoisirSon.Text = "...";
			this.btnChoisirSon.UseVisualStyleBackColor = true;
			// 
			// tbSon
			// 
			this.tbSon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSon.Location = new System.Drawing.Point(6, 19);
			this.tbSon.Name = "tbSon";
			this.tbSon.ReadOnly = true;
			this.tbSon.Size = new System.Drawing.Size(461, 20);
			this.tbSon.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbBoucle);
			this.groupBox2.Controls.Add(this.btnArreter);
			this.groupBox2.Controls.Add(this.btnJouer);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 70);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(241, 119);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gestion du son";
			// 
			// cbBoucle
			// 
			this.cbBoucle.AutoSize = true;
			this.cbBoucle.Location = new System.Drawing.Point(112, 48);
			this.cbBoucle.Name = "cbBoucle";
			this.cbBoucle.Size = new System.Drawing.Size(102, 17);
			this.cbBoucle.TabIndex = 2;
			this.cbBoucle.Text = "Jouer en boucle";
			this.cbBoucle.UseVisualStyleBackColor = true;
			// 
			// btnArreter
			// 
			this.btnArreter.Location = new System.Drawing.Point(8, 59);
			this.btnArreter.Name = "btnArreter";
			this.btnArreter.Size = new System.Drawing.Size(75, 23);
			this.btnArreter.TabIndex = 1;
			this.btnArreter.Text = "Arrete";
			this.btnArreter.UseVisualStyleBackColor = true;
			// 
			// btnJouer
			// 
			this.btnJouer.Location = new System.Drawing.Point(8, 30);
			this.btnJouer.Name = "btnJouer";
			this.btnJouer.Size = new System.Drawing.Size(75, 23);
			this.btnJouer.TabIndex = 0;
			this.btnJouer.Text = "Jouer";
			this.btnJouer.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.trackBar1);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.lblVolume);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(250, 70);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(277, 119);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Contrôle du son";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(9, 48);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(252, 45);
			this.trackBar1.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(57, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(43, 20);
			this.textBox1.TabIndex = 1;
			// 
			// lblVolume
			// 
			this.lblVolume.AutoSize = true;
			this.lblVolume.Location = new System.Drawing.Point(6, 16);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(45, 13);
			this.lblVolume.TabIndex = 0;
			this.lblVolume.Text = "Volume:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.71533F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.28467F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.20408F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.79592F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 192);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 192);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Son";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnChoisirSon;
		private System.Windows.Forms.TextBox tbSon;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox cbBoucle;
		private System.Windows.Forms.Button btnArreter;
		private System.Windows.Forms.Button btnJouer;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblVolume;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

