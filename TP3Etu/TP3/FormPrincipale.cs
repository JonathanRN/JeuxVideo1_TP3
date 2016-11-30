using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace TP3
{
	public partial class FormPrincipale : Form
	{
    #region Propriétés /  variables partagées par toutes les méthodes.
    //Position du bloc de rotation
    static int colonneCourante = 3;
    static int ligneCourante = 0;
    //Position relative du bloc actif selon le bloc de rotation
    static int[] blocActifX = new int[4] { 0, 0, 0, 0 };
    static int[] blocActifY = new int[4] { 0, 0, 0, 0 };
		//Nombre de colonnes dans le jeu
		static int nbColonnesJeu = 10;
		//Nombre de lignes dans le jeu
		static int nbLignesJeu = 20;
		// Initialisation du bloc courant
		TypeBloc blocCourant = TypeBloc.None;

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
			bool tourEstTermine = false;
			// Ne pas oublier de mettre en place les valeurs nécessaires à une partie.
      ExecuterTestsUnitaires();
			InitialiserSurfaceDeJeu(20, 10);
			blocCourant = ChoisirBlocAleatoire();
			CreeNouveauBlocActif(blocCourant);
			timerBlocDescente.Enabled = true;
			while (tourEstTermine == false)
			{
				AfficherBlocActif(blocCourant);
				tourEstTermine = true;
			}
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
		/// <summary>
		/// Fait par Kevin et Jo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormPrincipale_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Bas
			if (e.KeyChar == (char)Keys.S)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.DéplacerBas);
				AfficherBlocActif(blocCourant);
			}
			// Gauche
			else if (e.KeyChar == (char)Keys.A)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.DéplacerGauche);
				AfficherBlocActif(blocCourant);
			}
			// Droite
			else if (e.KeyChar == (char)Keys.D)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.DéplacerDroit);
				AfficherBlocActif(blocCourant);
			}
			// Hold
			else if (e.KeyChar == (char)Keys.O)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.DéplacerHold);
				AfficherBlocActif(blocCourant);
			}
			// Sauter
			else if (e.KeyChar == (char)Keys.Space)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.HardDrop);
				AfficherBlocActif(blocCourant);
			}
			// Rotation antihoraire
			else if (e.KeyChar == (char)Keys.K)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.RotationAntiHoraire);
				AfficherBlocActif(blocCourant);
			}
			// Rotation Horaire
			else if (e.KeyChar == (char)Keys.L)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.RotationHoraire);
				AfficherBlocActif(blocCourant);
			}
		}

		/// <summary>
		/// Fait par Jo
		/// </summary>
		/// <returns></returns>
		TypeBloc ChoisirBlocAleatoire()
		{
			Random rnd = new Random();
			int randomBloc;
			randomBloc = rnd.Next(2, 8);

			if (randomBloc == 2)
			{
				return TypeBloc.Carré;
			}
			else if (randomBloc == 3)
			{
				return TypeBloc.Ligne;
			}
			else if (randomBloc == 3)
			{
				return TypeBloc.T;
			}
			else if (randomBloc == 4)
			{
				return TypeBloc.L;
			}
			else if (randomBloc == 5)
			{
				return TypeBloc.J;
			}
			else if (randomBloc == 6)
			{
				return TypeBloc.S;
			}
			else
			{
				return TypeBloc.Z;
			}
		}

		/// <summary>
		/// Fait par Jo
		/// </summary>
		/// <returns></returns>
		void CreeNouveauBlocActif(TypeBloc bloc)
		{			
			// Carré
			if (bloc == TypeBloc.Carré)
			{
				//Positions Y
				blocActifY[0] = 0;
				blocActifY[1] = 0;
				blocActifY[2] = 1;
				blocActifY[3] = 1;
				//Positions X
				blocActifX[0] = 1;
				blocActifX[1] = 2;
				blocActifX[2] = 1;
				blocActifX[3] = 2;
			}
			// Ligne
			else if (bloc == TypeBloc.Ligne)
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
			}
			// T
			else if (bloc == TypeBloc.T)
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
			}
			// L
			else if (bloc == TypeBloc.L)
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
			}
			// J
			else if (bloc == TypeBloc.J)
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
				blocActifX[3] = 0;
			}
			// S
			else if (bloc == TypeBloc.S)
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
			}
			// Z
			else
			{
				// Positions Y
				blocActifY[0] = 0;
				blocActifY[1] = 1;
				blocActifY[2] = 1;
				blocActifY[3] = 2;
				//Positions X
				blocActifX[0] = 1;
				blocActifX[1] = 1;
				blocActifX[2] = 0;
				blocActifX[3] = 0;
			}			
		}

		/// <summary>
		/// Fait par Jo
		/// </summary>
		/// <param name="rotationPiece"></param>
		void RotationBlocs(TouchesJoueur rotationBlocs)
		{
			int[] temporaire = new int[blocActifX.Length];
			if (rotationBlocs == TouchesJoueur.RotationAntiHoraire)
			{
				//Rotation de 90 degrés Antihoraire
				temporaire[0] = blocActifY[0];
				temporaire[1] = blocActifY[1];
				temporaire[2] = blocActifY[2];
				temporaire[3] = blocActifY[3];

				blocActifY[0] = -1 * blocActifX[0];
				blocActifY[1] = -1 * blocActifX[1];
				blocActifY[2] = -1 * blocActifX[2];
				blocActifY[3] = -1 * blocActifX[3];

				blocActifX[0] = temporaire[0];
				blocActifX[1] = temporaire[1];
				blocActifX[2] = temporaire[2];
				blocActifX[3] = temporaire[3];
			}
			if (rotationBlocs == TouchesJoueur.RotationHoraire)
			{
				//Rotation de 90 degrés horaire
				temporaire[0] = blocActifY[0];
				temporaire[1] = blocActifY[1];
				temporaire[2] = blocActifY[2];
				temporaire[3] = blocActifY[3];

				blocActifY[0] = blocActifX[0];
				blocActifY[1] = blocActifX[1];
				blocActifY[2] = blocActifX[2];
				blocActifY[3] = blocActifX[3];

				blocActifX[0] = -1 * temporaire[0];
				blocActifX[1] = -1 * temporaire[1];
				blocActifX[2] = -1 * temporaire[2];
				blocActifX[3] = -1 * temporaire[3];
			}
		}

		/// <summary>
		/// Fait par Kevin
		/// </summary>
		/// <param name="blocActif"></param>
		void AfficherBlocActif(TypeBloc blocActif)
		{     
			if (blocActif == TypeBloc.Carré)
			{
				ChangerImageAffichage(Properties.Resources.Carré);
			}
			if (blocActif == TypeBloc.Ligne)
			{
				ChangerImageAffichage(Properties.Resources.Ligne);
			}
			if (blocActif == TypeBloc.J)
			{
				ChangerImageAffichage(Properties.Resources.J);
			}
			if (blocActif == TypeBloc.L)
			{
				ChangerImageAffichage(Properties.Resources.L);
			}
			if (blocActif == TypeBloc.S)
			{
				ChangerImageAffichage(Properties.Resources.S);
			}
			if (blocActif == TypeBloc.T)
			{
				ChangerImageAffichage(Properties.Resources.T);
			}
			if (blocActif == TypeBloc.Z)
			{
				ChangerImageAffichage(Properties.Resources.Z);
			}
		}

		/// <summary>
		/// Fait par Kevin
		/// </summary>
		/// <param name="bloc"></param>
		void ChangerImageAffichage(Bitmap bloc)
		{
			toutesImagesVisuelles[ligneCourante + blocActifY[0], colonneCourante + blocActifX[0]].BackgroundImage = bloc;
			toutesImagesVisuelles[ligneCourante + blocActifY[1], colonneCourante + blocActifX[1]].BackgroundImage = bloc;
			toutesImagesVisuelles[ligneCourante + blocActifY[2], colonneCourante + blocActifX[2]].BackgroundImage = bloc;
			toutesImagesVisuelles[ligneCourante + blocActifY[3], colonneCourante + blocActifX[3]].BackgroundImage = bloc;
		}
			
		/// <summary>
		/// Fait par Kevin
		/// </summary>
		/// <param name="deplacement"></param>
		void DeplacerBloc(TouchesJoueur deplacement)
		{
			if (deplacement == TouchesJoueur.DéplacerDroit)
			{
				colonneCourante++;
			}
			if (deplacement == TouchesJoueur.DéplacerGauche)
			{
				colonneCourante--;
			}
			if (deplacement == TouchesJoueur.DéplacerBas)
			{
				ligneCourante++;
			}
			if (deplacement == TouchesJoueur.RotationAntiHoraire)
			{
				RotationBlocs(TouchesJoueur.RotationAntiHoraire);
			}
			if (deplacement == TouchesJoueur.RotationHoraire)
			{
				RotationBlocs(TouchesJoueur.RotationHoraire);
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

		private void timerBlocDescente_Tick(object sender, EventArgs e)
		{
			ChangerImageAffichage(Properties.Resources.justedunoir);
			DeplacerBloc(TouchesJoueur.DéplacerBas);
			AfficherBlocActif(blocCourant);
		}
		#endregion
	}
}
