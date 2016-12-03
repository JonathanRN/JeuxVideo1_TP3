using System;
using System.Windows.Forms;
using WMPLib;

namespace ProjetExempleSon
{
  public partial class Form1 : Form
  {
    // Variable nécessaire pour jouer un son
    WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();

    public Form1()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Joue un son prédéterminé lorsque l'utilisateur appuie sur le bouton "Jouer un son"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnPlaySound_Click(object sender, EventArgs e)
    {
      // Spécifier la source du son.  Le chemin d'accès doit être 
      // relatif à l'endroit où se trouve le fichier .exe
      mediaPlayer.URL = "Art/background.mp3";

      // Démarrer la lecture
      mediaPlayer.controls.play();      
    }

    /// <summary>
    /// Arrête le son qui joue lorsque l'utilisateur appuie sur le bouton "Arrêter le son"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStopSound_Click(object sender, EventArgs e)
    {
      // Si le son est en train de jouer
      if (mediaPlayer.playState == WMPPlayState.wmppsPlaying)
      {
        // On l'arrête
        mediaPlayer.controls.stop();
      }
    }
  }
}
