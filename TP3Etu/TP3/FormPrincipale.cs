using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using WMPLib;


namespace TP3
{
	public partial class FormPrincipale : Form
	{
    #region Propriétés /  variables partagées par toutes les méthodes.
    //Position du bloc de rotation
    static int colonneCourante = 3;
    static int ligneCourante = 1;
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
    //Score
    public static int score = 0;
		public static Stopwatch stopWatch = new Stopwatch();
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
			InitialiserSurfaceDeJeu(nbLignesJeu, nbColonnesJeu);
			InitialiserTour();
			// Timer
			timerTemps.Enabled = true;
			stopWatch.Start();
		}

    void InitialiserTour()
    {
      colonneCourante = nbColonnesJeu/2 - 1;
      ligneCourante = 1;
      blocCourant = ChoisirBlocAleatoire();
      CreeNouveauBlocActif(blocCourant);
      timerBlocDescente.Enabled = true;
      AfficherBlocActif(blocCourant);
      score += AttribuerPoint( RetireerLignesCompletees());
      lblScore.Text = score.ToString();
			GererPartieTerminee();
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
                    newPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
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

			// Initialisation du tableau de jeu
			for (int i = 0; i < nbLignesJeu; i++)
			{
				for (int j = 0; j < nbColonnesJeu; j++)
				{
					tableauDeJeu[i, j] = TypeBloc.None;
				}
			}

			// Initialisation du tableau nombres de pieces de la frmStatistiques
			for (int i = 0; i < frmStatistiques.nombrePieces.Length; i++)
			{
				frmStatistiques.nombrePieces[i] = 0;
			}
		}
		#endregion

		#region Code à développer
		/// <summary>
		/// Fait par Jo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// Bas
			if (keyData == Keys.Down)
			{
                if (BlocPeutBouger(TouchesJoueur.DéplacerBas) == true)
                {
                    ChangerImageAffichage(Properties.Resources.justedunoir);
                }
                DeplacerBloc(TouchesJoueur.DéplacerBas);
				AfficherBlocActif(blocCourant);
			}
			// Gauche
			else if (keyData == Keys.Left)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.DéplacerGauche);
				AfficherBlocActif(blocCourant);
			}
			// Droite
			else if (keyData == Keys.Right)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.DéplacerDroit);
				AfficherBlocActif(blocCourant);
			}
			// Hold
			else if (keyData == Keys.C)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.DéplacerHold);
				AfficherBlocActif(blocCourant);
			}
			// Drop
			else if (keyData == Keys.Space)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.HardDrop);
				AfficherBlocActif(blocCourant);
			}
			// Rotation antihoraire
			else if (keyData == Keys.Z)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.RotationAntiHoraire);
				AfficherBlocActif(blocCourant);
			}
			// Rotation Horaire
			else if (keyData == Keys.X)
			{
				ChangerImageAffichage(Properties.Resources.justedunoir);
				DeplacerBloc(TouchesJoueur.RotationHoraire);
				AfficherBlocActif(blocCourant);
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
      
    int AttribuerPoint(int score)
    {
      if (score == 1)
      {
          return 1;
      }
      else if (score == 2)
      {
          return 5;
      }
      else if (score == 3)
      {
          return 10;
      }
      else if (score == 4)
      {
          return 20;
      }
      else
      {
          return score;
      }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    int RetireerLignesCompletees()
    {
      int nbLigneComplete = 0;
      bool ligneComplete;
      for (int i = nbLignesJeu-1; i > 0; i--)
      {
        ligneComplete = EstUneLigneComplete(i);
        if (ligneComplete == true)
        {
          DecalerLigne(i - 1);
          nbLigneComplete++;
          i++;
        }
      }
      return nbLigneComplete;
    }

    void DecalerLigne(int ligneDeDepart)
    {
			for (int i = ligneDeDepart; i > 0; i--)
			{
				for (int j = 0; j < tableauDeJeu.GetLength(1); j++)
				{
					
					tableauDeJeu[i + 1, j] = tableauDeJeu[i, j];
					tableauDeJeu[i, j] = TypeBloc.None;
					toutesImagesVisuelles[i + 1, j].BackgroundImage = toutesImagesVisuelles[i, j].BackgroundImage;
					toutesImagesVisuelles[i, j].BackgroundImage = Properties.Resources.justedunoir;
				}
			}
		    
	}

		bool EstUneLigneComplete(int ligne)
    {
            bool ligneComplete = true;
            for (int i = 0; i < tableauDeJeu.GetLength(1); i++)
            {
                if(tableauDeJeu[ligne,i] == TypeBloc.None)
                {
                    ligneComplete = false;
                }
            }
            return ligneComplete;
        }

		/// <summary>
		/// Fait par Jo
		/// </summary>
		/// <returns></returns>
		TypeBloc ChoisirBlocAleatoire()
		{
			Random rnd = new Random();
			int randomBloc;
			randomBloc = rnd.Next(2, 9);

			if (randomBloc == 2)
			{
				frmStatistiques.nombrePieces[0]++;
				return TypeBloc.Carré;
			}
			else if (randomBloc == 3)
			{
				frmStatistiques.nombrePieces[1]++;
				return TypeBloc.Ligne;
			}
			else if (randomBloc == 4)
			{
				frmStatistiques.nombrePieces[2]++;
				return TypeBloc.T;
			}
			else if (randomBloc == 5)
			{
				frmStatistiques.nombrePieces[3]++;
				return TypeBloc.L;
			}
			else if (randomBloc == 6)
			{
				frmStatistiques.nombrePieces[4]++;
				return TypeBloc.J;
			}
			else if (randomBloc == 7)
			{
				frmStatistiques.nombrePieces[5]++;
				return TypeBloc.S;
			}
			else
			{
				frmStatistiques.nombrePieces[6]++;
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
				blocActifX[0] = 0;
				blocActifX[1] = 1;
				blocActifX[2] = 0;
				blocActifX[3] = 1;
			}
			// Ligne
			else if (bloc == TypeBloc.Ligne)
			{
				// Positions Y
				blocActifY[0] = -1;
				blocActifY[1] = 0;
				blocActifY[2] = 1;
				blocActifY[3] = 2;
				//Positions X
				blocActifX[0] = 0;
				blocActifX[1] = 0;
				blocActifX[2] = 0;
				blocActifX[3] = 0;
			}
			// T
			else if (bloc == TypeBloc.T)
			{
				// Positions Y
				blocActifY[0] = -1;
				blocActifY[1] = 0;
				blocActifY[2] = 0;
				blocActifY[3] = 0;
				//Positions X
				blocActifX[0] = 0;
				blocActifX[1] = -1;
				blocActifX[2] = 0;
				blocActifX[3] = 1;
			}
			// L
			else if (bloc == TypeBloc.L)
			{
				// Positions Y
				blocActifY[0] = -1;
				blocActifY[1] = 0;
				blocActifY[2] = 1;
				blocActifY[3] = 1;
				//Positions X
				blocActifX[0] = 0;
				blocActifX[1] = 0;
				blocActifX[2] = 0;
				blocActifX[3] = 1;
			}
			// J
			else if (bloc == TypeBloc.J)
			{
				// Positions Y
				blocActifY[0] = -1;
				blocActifY[1] = 0;
				blocActifY[2] = 1;
				blocActifY[3] = 1;
				//Positions X
				blocActifX[0] = 0;
				blocActifX[1] = 0;
				blocActifX[2] = 0;
				blocActifX[3] = -1;
			}
			// S
			else if (bloc == TypeBloc.S)
			{
				// Positions Y
				blocActifY[0] = 1;
				blocActifY[1] = 1;
				blocActifY[2] = 0;
				blocActifY[3] = 0;
				//Positions X
				blocActifX[0] = -1;
				blocActifX[1] = 0;
				blocActifX[2] = 0;
				blocActifX[3] = 1;
			}
			// Z
			else
			{
				// Positions Y
				blocActifY[0] = 0;
				blocActifY[1] = 0;
				blocActifY[2] = 1;
				blocActifY[3] = 1;
				//Positions X
				blocActifX[0] = -1;
				blocActifX[1] = 0;
				blocActifX[2] = 0;
				blocActifX[3] = 1;
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
		/// Fait par Jo
		/// </summary>
		/// <param name="bloc"></param>
		void ChangerBlocCourant()
		{
			tableauDeJeu[ligneCourante + blocActifY[0], colonneCourante + blocActifX[0]] = TypeBloc.Gelé;
			tableauDeJeu[ligneCourante + blocActifY[1], colonneCourante + blocActifX[1]] = TypeBloc.Gelé;
			tableauDeJeu[ligneCourante + blocActifY[2], colonneCourante + blocActifX[2]] = TypeBloc.Gelé;
			tableauDeJeu[ligneCourante + blocActifY[3], colonneCourante + blocActifX[3]] = TypeBloc.Gelé;
		}

		/// <summary>
		/// Fait par Kevin et Jo
		/// </summary>
		/// <param name="deplacement"></param>
		void DeplacerBloc(TouchesJoueur deplacement)
		{
			if (deplacement == TouchesJoueur.DéplacerDroit)
			{
				if (BlocPeutBouger(TouchesJoueur.DéplacerDroit) == true)
				{
					colonneCourante++;
				}
              
			}
			if (deplacement == TouchesJoueur.DéplacerGauche)
			{
				if (BlocPeutBouger(TouchesJoueur.DéplacerGauche) == true)
				{
					colonneCourante--;
				}
			}
			if (deplacement == TouchesJoueur.DéplacerBas)
			{
				if (BlocPeutBouger(TouchesJoueur.DéplacerBas) == true)
				{
					ligneCourante++;
				}
				else 
				{
          ChangerBlocCourant();
					if (timerBlocDescente.Enabled == true)
					{
						InitialiserTour();
					}
        }
			}
			if (deplacement == TouchesJoueur.RotationAntiHoraire)
			{
        RotationBlocs(TouchesJoueur.RotationAntiHoraire);
        if (BlocPeutBouger(TouchesJoueur.RotationAntiHoraire) == false)
        {
            RotationBlocs(TouchesJoueur.RotationHoraire);
        }
               
			}
			if (deplacement == TouchesJoueur.RotationHoraire)
			{
        RotationBlocs(TouchesJoueur.RotationHoraire);
        if (BlocPeutBouger(TouchesJoueur.RotationHoraire) == false)
        {
            RotationBlocs(TouchesJoueur.RotationAntiHoraire);
        } 
			}
			if (deplacement == TouchesJoueur.HardDrop)
			{
				for (int i = 0; i < tableauDeJeu.GetLength(0); i++)
				{
					if (BlocPeutBouger(TouchesJoueur.DéplacerBas) == true)
					{
						ligneCourante++;
					}
				}
			}
		}

		/// <summary>
		/// Fait par Kevin
		/// </summary>
		/// <param name="deplacement"></param>
		/// <returns></returns>
    bool BlocPeutBouger(TouchesJoueur deplacement)
    {
        bool peutBouger = true;
        if (deplacement == TouchesJoueur.DéplacerBas)
        {
            for (int i = 0; i < 4; i++)
            {
                if (ligneCourante + blocActifY[i] + 1 < nbLignesJeu && tableauDeJeu[ligneCourante+blocActifY[i] +1,colonneCourante + blocActifX[i]] == TypeBloc.None)
                {
                    peutBouger = true;
                }
                else
                {
                    return false;
                }

            }
        }
        if (deplacement == TouchesJoueur.DéplacerGauche)
        {
            for (int i = 0; i < 4; i++)
            {
                if (colonneCourante + blocActifX[i] > 0 && tableauDeJeu[ligneCourante + blocActifY[i], colonneCourante + blocActifX[i] -1] == TypeBloc.None)
                {
                    peutBouger = true;
                }
                else
                {
                    return false;
                }

            }
        }
        if (deplacement == TouchesJoueur.DéplacerDroit)
        {
            for (int i = 0; i < 4; i++)
            {
                if (colonneCourante + blocActifX[i] +1  < nbColonnesJeu && tableauDeJeu[ligneCourante + blocActifY[i], colonneCourante + blocActifX[i]+1] == TypeBloc.None)
                {
                    peutBouger = true;
                }
                else
                {
                    return false;
                }

            }
        }
        if (deplacement == TouchesJoueur.RotationAntiHoraire)
        {
               
            for (int i = 0; i < 4; i++)
            {
                    
                if (ligneCourante + blocActifY[i] < nbLignesJeu && colonneCourante + blocActifX[i] < nbColonnesJeu && colonneCourante + blocActifX[i] > 0 && ligneCourante + blocActifY[i] > 0 && tableauDeJeu[ligneCourante + blocActifY[i], colonneCourante + blocActifX[i]] == TypeBloc.None)
                {
                    peutBouger = true;
                }
                else
                {
                       

                    return false;
                }

            }
        }
        if (deplacement == TouchesJoueur.RotationHoraire)
        {
              
            for (int i = 0; i < 4; i++)
            {
                    
                if (ligneCourante + blocActifY[i] < nbLignesJeu && colonneCourante + blocActifX[i] < nbColonnesJeu && colonneCourante + blocActifX[i] > 0 && ligneCourante + blocActifY[i] > 0 && tableauDeJeu[ligneCourante + blocActifY[i], colonneCourante + blocActifX[i]] == TypeBloc.None)
                {
									peutBouger = true;
                }
                else
                {
									return false;
                }
                   

            }
        }



        return peutBouger;
    }

		bool PartieEstTerminee()
		{
			bool estTerminee = false;
			for (int i = 0; i < 4; i++)
			{
				if (ligneCourante + blocActifY[i] + 1 < nbLignesJeu && tableauDeJeu[ligneCourante + blocActifY[i] + 1, colonneCourante + blocActifX[i]] == TypeBloc.Gelé
				&& ligneCourante == 1)
				{
					estTerminee = true;
				}
				else
				{
					estTerminee = false;
				}
			}
			return estTerminee;
		}

		void GererPartieTerminee()
		{
			if (PartieEstTerminee() == true)
			{
				timerBlocDescente.Enabled = false;
				frmStatistiques stats = new frmStatistiques();
				stats.ShowDialog();
				DialogResult resultat = frmStatistiques.resultat;
				if (resultat == DialogResult.OK)
				{
					ReinitialiserJeu();
				}
			}
		}

		void ReinitialiserJeu()
		{
			lblScore.Text = "0";
			score = 0;

			// Tableau de nombre de pieces
			for (int i = 0; i < frmStatistiques.nombrePieces.Length; i++)
			{
				frmStatistiques.nombrePieces[i] = 0;
			}

			// Tableau de jeu et picturesbox
			for (int i = 0; i < nbLignesJeu; i++)
			{
				for (int j = 0; j < nbColonnesJeu; j++)
				{
					tableauDeJeu[i, j] = TypeBloc.None;
					toutesImagesVisuelles[i, j].BackgroundImage = Properties.Resources.justedunoir;
				}
			}

			// Timer
			timerTemps.Enabled = false;
			timerTemps.Enabled = true;
			stopWatch.Stop();
			stopWatch.Start();
			InitialiserTour();
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
			if (BlocPeutBouger(TouchesJoueur.DéplacerBas) == true)
			{
					ChangerImageAffichage(Properties.Resources.justedunoir);
			}
			DeplacerBloc(TouchesJoueur.DéplacerBas);
			AfficherBlocActif(blocCourant);
		}
		#endregion

		#region Boutons
		private void btnParametres_MouseClick(object sender, MouseEventArgs e)
    {
      timerBlocDescente.Enabled = false;
      frmParametre parametre = new frmParametre();
      parametre.ShowDialog();
      DialogResult resultat = frmParametre.resultat;
      if (resultat == DialogResult.OK)
      {
				nbLignesJeu = frmParametre.nbLignes;
				nbColonnesJeu = frmParametre.nbColonnes;
				tableauDeJeu = new TypeBloc[nbLignesJeu, nbColonnesJeu];
				InitialiserSurfaceDeJeu(nbLignesJeu, nbColonnesJeu);
				ReinitialiserJeu();
      }
      if (resultat == DialogResult.Cancel)
      {
				timerBlocDescente.Enabled = true;
      }
    }

		private void recommencerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReinitialiserJeu();
		}

		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Quitter le jeu ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			timerBlocDescente.Enabled = false;
			frmStatistiques stats = new frmStatistiques();
			stats.ShowDialog();
			DialogResult resultat = frmStatistiques.resultat;
			if (resultat == DialogResult.OK)
			{
				ReinitialiserJeu();
			}
		}
		#endregion
	}
}
