namespace TP3
{
    partial class frmParametre
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
            this.numericUpDownColonnes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLignes = new System.Windows.Forms.NumericUpDown();
            this.OK = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLignes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColonne
            // 
            this.lblColonne.AutoSize = true;
            this.lblColonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonne.Location = new System.Drawing.Point(14, 19);
            this.lblColonne.Name = "lblColonne";
            this.lblColonne.Size = new System.Drawing.Size(127, 13);
            this.lblColonne.TabIndex = 0;
            this.lblColonne.Text = "Nombre de colonnes:";
            // 
            // lblLignes
            // 
            this.lblLignes.AutoSize = true;
            this.lblLignes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLignes.Location = new System.Drawing.Point(14, 49);
            this.lblLignes.Name = "lblLignes";
            this.lblLignes.Size = new System.Drawing.Size(109, 13);
            this.lblLignes.TabIndex = 1;
            this.lblLignes.Text = "Nombre de lignes:";
            // 
            // numericUpDownColonnes
            // 
            this.numericUpDownColonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownColonnes.Location = new System.Drawing.Point(171, 19);
            this.numericUpDownColonnes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownColonnes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownColonnes.Name = "numericUpDownColonnes";
            this.numericUpDownColonnes.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownColonnes.TabIndex = 2;
            this.numericUpDownColonnes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownColonnes.ValueChanged += new System.EventHandler(this.numericUpDownColonnes_ValueChanged);
            // 
            // numericUpDownLignes
            // 
            this.numericUpDownLignes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLignes.Location = new System.Drawing.Point(171, 46);
            this.numericUpDownLignes.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownLignes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLignes.Name = "numericUpDownLignes";
            this.numericUpDownLignes.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownLignes.TabIndex = 3;
            this.numericUpDownLignes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLignes.ValueChanged += new System.EventHandler(this.numericUpDownLignes_ValueChanged);
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(17, 109);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(104, 27);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Annuler
            // 
            this.Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(171, 109);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(104, 27);
            this.Annuler.TabIndex = 5;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(17, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Musique";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP3.Properties.Resources.cropped_tetris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 154);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.numericUpDownLignes);
            this.Controls.Add(this.numericUpDownColonnes);
            this.Controls.Add(this.lblLignes);
            this.Controls.Add(this.lblColonne);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmParametre";
            this.Text = "Paramètre";
            this.Load += new System.EventHandler(this.Parametre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLignes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColonne;
        private System.Windows.Forms.Label lblLignes;
        private System.Windows.Forms.NumericUpDown numericUpDownColonnes;
        private System.Windows.Forms.NumericUpDown numericUpDownLignes;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}