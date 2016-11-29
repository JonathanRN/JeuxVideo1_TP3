﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP3
{
	public partial class FormPrincipale : Form
	{
    #region Propriétés /  variables partagées par toutes les méthodes.
    //Position du bloc de rotation
    static int colonneCourante = 0;
    static int ligneCourante = 0;
    //Position relative du bloc actif selon le bloc de rotation
    static int[] blocActifX = new int[4] { 0, 0, 0, 0 };
    static int[] blocActifY = new int[4] { 0, 0, 0, 0 };
		//Nombre de colonnes dans le jeu
		static int nbColonnesJeu = 10;
		//Nombre de lignes dans le jeu
		static int nbLignesJeu = 20;
		//Énumération des différents types de blocs dans le jeu
		enum TypeBloc { None, Gelé, Carré, Ligne, T, L, J, S, Z };

		TypeBloc[,] tableauDeJeu = new TypeBloc[nbLignesJeu, nbColonnesJeu];
		#endregion

		public FormPrincipale( )
    {
      InitializeComponent( );
    }
      
    #region Code fourni
    
    // Représentation visuelles du jeu en mémoire.
    static PictureBox[,] toutesImagesVisuelles = null;
        
    
    /// <summary>
    /// Gestionnaire de l'événement se produisant lors du premier affichage 
    /// du formulaire principal.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmLoad( object sender, EventArgs e )
    {
      // Ne pas oublier de mettre en place les valeurs nécessaires à une partie.
      ExecuterTestsUnitaires();
      InitialiserSurfaceDeJeu(20,10);
			AfficherBlocActif(CreeNouveauBlocActif());
    }

    private void InitialiserSurfaceDeJeu(int nbLignes, int nbCols)
    {
      // Création d'une surface de jeu 10 colonnes x 20 lignes
      toutesImagesVisuelles = new PictureBox[nbLignes, nbCols];
      tableauJeu.Controls.Clear();
      tableauJeu.ColumnCount = toutesImagesVisuelles.GetLength(1);
      tableauJeu.RowCount = toutesImagesVisuelles.GetLength(0);
      for (int i = 0; i < tableauJeu.RowCount; i++)
      {
        tableauJeu.RowStyles[i].Height = tableauJeu.Height / tableauJeu.RowCount;
        for (int j = 0; j < tableauJeu.ColumnCount; j++)
        {
          tableauJeu.ColumnStyles[j].Width = tableauJeu.Width / tableauJeu.ColumnCount;
          // Création dynamique des PictureBox qui contiendront les pièces de jeu
          PictureBox newPictureBox = new PictureBox();
          newPictureBox.Width = tableauJeu.Width / tableauJeu.ColumnCount;
          newPictureBox.Height = tableauJeu.Height / tableauJeu.RowCount;
          newPictureBox.BackColor = Color.Black;
          newPictureBox.Margin = new Padding(0, 0, 0, 0);
          newPictureBox.BorderStyle = BorderStyle.FixedSingle;
          newPictureBox.Dock = DockStyle.Fill;

          // Assignation de la représentation visuelle.
          toutesImagesVisuelles[i, j] = newPictureBox;
          // Ajout dynamique du PictureBox créé dans la grille de mise en forme.
          // A noter que l' "origine" du repère dans le tableau est en haut à gauche.
          tableauJeu.Controls.Add(newPictureBox, j, i);
        }
      }

			// Initialisation du tableau
			for (int i = 0; i < nbLignesJeu; i++)
			{
				for (int j = 0; j < nbColonnesJeu; j++)
				{
					tableauDeJeu[i, j] = TypeBloc.None;
				}
			}
    }
    #endregion

    #region Code à développer
		TypeBloc CreeNouveauBlocActif()
		{
			Random rnd = new Random();
			int random = 0;
			random = rnd.Next(2, 8);
			
			// Carré
			if (random == 2)
			{
				// Positions Y
				blocActifY[0] = 0;
				blocActifY[1] = 0;
				blocActifY[2] = 1;
				blocActifY[3] = 1;
				//Positions X
				blocActifX[0] = 1;
				blocActifX[1] = 2;
				blocActifX[2] = 1;
				blocActifX[3] = 2;
				return TypeBloc.Carré;
			}
			// Ligne
			else if (random == 3)
			{
				// Positions Y
				blocActifY[0] = 0;
				blocActifY[1] = 1;
				blocActifY[2] = 2;
				blocActifY[3] = 3;
				//Positions X
				blocActifX[0] = 1;
				blocActifX[1] = 1;
				blocActifX[2] = 1;
				blocActifX[3] = 1;
				return TypeBloc.Ligne;
			}
			// T
			else if (random == 4)
			{
				// Positions Y
				blocActifY[0] = 0;
				blocActifY[1] = 1;
				blocActifY[2] = 1;
				blocActifY[3] = 1;
				//Positions X
				blocActifX[0] = 1;
				blocActifX[1] = 0;
				blocActifX[2] = 1;
				blocActifX[3] = 2;
				return TypeBloc.T;
			}
			// L
			else if (random == 5)
			{
				// Positions Y
				blocActifY[0] = 0;
				blocActifY[1] = 1;
				blocActifY[2] = 2;
				blocActifY[3] = 2;
				//Positions X
				blocActifX[0] = 1;
				blocActifX[1] = 1;
				blocActifX[2] = 1;
				blocActifX[3] = 2;
				return TypeBloc.L;
			}
			// J
			else if (random == 6)
			{
				// Positions Y
				blocActifY[0] = 1;
				blocActifY[1] = 2;
				blocActifY[2] = 3;
				blocActifY[3] = 3;
				//Positions X
				blocActifX[0] = 2;
				blocActifX[1] = 2;
				blocActifX[2] = 2;
				blocActifX[3] = 1;
				return TypeBloc.J;
			}
			// S
			else if (random == 7)
			{
				// Positions Y
				blocActifY[0] = 0;
				blocActifY[1] = 1;
				blocActifY[2] = 1;
				blocActifY[3] = 2;
				//Positions X
				blocActifX[0] = 1;
				blocActifX[1] = 1;
				blocActifX[2] = 2;
				blocActifX[3] = 2;
				return TypeBloc.S;
			}
			// Z
			else  
			{
				// Positions Y
				blocActifY[0] = 1;
				blocActifY[1] = 2;
				blocActifY[2] = 2;
				blocActifY[3] = 3;
				//Positions X
				blocActifX[0] = 2;
				blocActifX[1] = 2;
				blocActifX[2] = 1;
				blocActifX[3] = 1;
				return TypeBloc.Z;
			}
			
		}
		void AfficherBlocActif(TypeBloc blocActif)
		{
			if (blocActif == TypeBloc.Carré)
			{
				toutesImagesVisuelles[ligneCourante + blocActifX[0], colonneCourante + blocActifY[0]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[1], colonneCourante + blocActifY[1]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[2], colonneCourante + blocActifY[2]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[3], colonneCourante + blocActifY[3]].BackColor = Color.Red;
			}
			if (blocActif == TypeBloc.Ligne)
			{
				toutesImagesVisuelles[ligneCourante + blocActifX[0], colonneCourante + blocActifY[0]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[1], colonneCourante + blocActifY[1]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[2], colonneCourante + blocActifY[2]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[3], colonneCourante + blocActifY[3]].BackColor = Color.Red;
			}
			if (blocActif == TypeBloc.J)
			{
				toutesImagesVisuelles[ligneCourante + blocActifX[0], colonneCourante + blocActifY[0]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[1], colonneCourante + blocActifY[1]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[2], colonneCourante + blocActifY[2]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[3], colonneCourante + blocActifY[3]].BackColor = Color.Red;
			}
			if (blocActif == TypeBloc.L)
			{
				toutesImagesVisuelles[ligneCourante + blocActifX[0], colonneCourante + blocActifY[0]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[1], colonneCourante + blocActifY[1]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[2], colonneCourante + blocActifY[2]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[3], colonneCourante + blocActifY[3]].BackColor = Color.Red;
			}
			if (blocActif == TypeBloc.S)
			{
				toutesImagesVisuelles[ligneCourante + blocActifX[0], colonneCourante + blocActifY[0]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[1], colonneCourante + blocActifY[1]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[2], colonneCourante + blocActifY[2]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[3], colonneCourante + blocActifY[3]].BackColor = Color.Red;
			}
			if (blocActif == TypeBloc.T)
			{
				toutesImagesVisuelles[ligneCourante + blocActifX[0], colonneCourante + blocActifY[0]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[1], colonneCourante + blocActifY[1]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[2], colonneCourante + blocActifY[2]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[3], colonneCourante + blocActifY[3]].BackColor = Color.Red;
			}
			if (blocActif == TypeBloc.Z)
			{
				toutesImagesVisuelles[ligneCourante + blocActifX[0], colonneCourante + blocActifY[0]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[1], colonneCourante + blocActifY[1]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[2], colonneCourante + blocActifY[2]].BackColor = Color.Red;
				toutesImagesVisuelles[ligneCourante + blocActifX[3], colonneCourante + blocActifY[3]].BackColor = Color.Red;
			}



		}

    /// <summary>
    /// Faites ici les appels requis pour vos tests unitaires.
    /// </summary>
    void ExecuterTestsUnitaires()
    {      
      ExecuterTestABC();
      // A compléter...
    }

    // A renommer et commenter!
    void ExecuterTestABC()
    {
      // Mise en place des données du test
			
      
      // Exécuter de la méthode à tester
      
      // Validation des résultats
      
      // Clean-up
    }


    #endregion
  }
}
