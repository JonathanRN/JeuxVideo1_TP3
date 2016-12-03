using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
	public partial class frmStatistiques : Form
	{
		public frmStatistiques()
		{
			InitializeComponent();
		}
		public static DialogResult resultat;
		public static int[] nombrePieces = new int[7];
		public static int[] pourcentagePieces = new int[nombrePieces.Length];

		private void frmStatistiques_Load(object sender, EventArgs e)
		{
			int somme = 0;
			// Calcul de la somme pour le pourcentage
			for (int i = 0; i < nombrePieces.Length; i++)
			{
				somme += nombrePieces[i];
			}
			// Calcul du tableau pourcentage de la frmStatistiques
			for (int i = 0; i < pourcentagePieces.Length; i++)
			{
				pourcentagePieces[i] = ((nombrePieces[i] * 100) / somme);
			}

			lblCarréNombre.Text = nombrePieces[0].ToString();
			lblLigneNombre.Text = nombrePieces[1].ToString();
			lblTNombre.Text = nombrePieces[2].ToString();
			lblLNombre.Text = nombrePieces[3].ToString();
			lblJNombre.Text = nombrePieces[4].ToString();
			lblSNombre.Text = nombrePieces[5].ToString();
			lblZNombre.Text = nombrePieces[6].ToString();

			lblCarréPourcentage.Text = pourcentagePieces[0].ToString() + " %";
			lblLignePourcentage.Text = pourcentagePieces[1].ToString() + " %";
			lblTPourcentage.Text = pourcentagePieces[2].ToString() + " %";
			lblLPourcentage.Text = pourcentagePieces[3].ToString() + " %";
			lblJPourcentage.Text = pourcentagePieces[4].ToString() + " %";
			lblSPourcentage.Text = pourcentagePieces[5].ToString() + " %";
			lblZPourcentage.Text = pourcentagePieces[6].ToString() + " %";

			lblScore.Text = FormPrincipale.score.ToString();
			lblTemps.Text =
			FormPrincipale.stopWatch.Elapsed.Hours.ToString("00") + ":" +
			FormPrincipale.stopWatch.Elapsed.Minutes.ToString("00") + ":" +
			FormPrincipale.stopWatch.Elapsed.Seconds.ToString("00");
		}

		private void btnFermer_Click(object sender, EventArgs e)
		{
			resultat = btnFermer.DialogResult;
			this.Hide();
		}
	}
}
