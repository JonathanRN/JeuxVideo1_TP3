using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP3
{
	public partial class FormPrincipale : Form
	{
		#region Propriétés /  variables partagées par toutes les méthodes.
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
		void CreeNouveauBlocActif()
		{
			Random rnd = new Random(420);
			int random = 0;
			random = rnd.Next(2, 8);

			if (random == 2)
			{
				
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
