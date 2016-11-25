/*
 * Écrire ici la documentation générale. Indiquez quel est le but de votre application.
 * 
 * Indiquez aussi qui est (sont) l' (les) auteur(s).
 * Auteur:
 * Co-auteur (si applicable):
 * */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ProgrammationJeuxVideo1
{
	public class TESTS1
	{
		/// <summary>
		/// La méthode Run est le point de départ (point d'entrée)
		/// dans notre application.
		/// </summary>
		public void Run()
		{
			int nbColonnesJeu = 10;
			int nbLignesJeu = 20;

			int[,] tabJeu = new int[nbLignesJeu, nbColonnesJeu];

			// Initialisation a 0
			for (int i = 0; i < tabJeu.GetLength(0); i++)
			{
				for (int j = 0; j < tabJeu.GetLength(1); j++)
				{
					tabJeu[i, j] = 0;
					tabJeu[5, j] = 1;
					tabJeu[6, j] = 1;
					tabJeu[19, 1] = 1;
					tabJeu[18, 1] = 1;
					tabJeu[17, 1] = 1;
					tabJeu[17, 2] = 1;
					tabJeu[19, 2] = 1;
				}
			}

			DecalerLignes(7, tabJeu);

			for (int i = 0; i < tabJeu.GetLength(0); i++)
			{
				for (int j = 0; j < tabJeu.GetLength(1); j++)
				{
					Console.Write(string.Format("{0} ", tabJeu[i, j]));
				}
				Console.Write(Environment.NewLine);
			}
			Console.ReadLine();
		}

		void DecalerLignes(int lignedepart, int[,] tabJeu)
		{
			for (int i = 0; lignedepart < 0; i--)
			{
				for (int j = 0; j < tabJeu.GetLength(1); j++)
				{
					if (tabJeu[i, j] == 1)
					{
						tabJeu[i, j] = tabJeu[i + 1, j];
					}
				}
			}
		}
	}
}