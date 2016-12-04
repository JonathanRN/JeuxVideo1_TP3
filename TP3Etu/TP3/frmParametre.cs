using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class frmParametre : Form
    {
        public frmParametre()
        {
            InitializeComponent();
        }
        public static bool musiqueEstCheck = true;
        public static DialogResult resultat;
        public static int nbLignes;
        public static int nbColonnes;
        public  int SetNbLignes()

        {
            return (int)numericUpDownLignes.Value;               
        }
        public  int SetNbColonnes()
        {
            return (int)numericUpDownColonnes.Value;
        }
        void SetCheckBoxMusique()
        {
            if (checkBox1.Checked == true)
            {
                musiqueEstCheck = true;
            }
            else
            {
                musiqueEstCheck = false;
            }
        }

        private void Parametre_Load(object sender, EventArgs e)
        {
            nbLignes = SetNbLignes();
            nbColonnes = SetNbColonnes();
            SetCheckBoxMusique();
            
        }
       
        private void numericUpDownColonnes_ValueChanged(object sender, EventArgs e)
        {
            nbColonnes = SetNbColonnes();
        }

        private void numericUpDownLignes_ValueChanged(object sender, EventArgs e)
        {
            nbLignes = SetNbLignes();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            resultat = OK.DialogResult;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            resultat = Annuler.DialogResult;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckBoxMusique();
        }
    }
}
