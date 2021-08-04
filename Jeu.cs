using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Jeu : Form
    {

        ButtonJ[,] Echiquier = new ButtonJ[12, 12];
        int ii;
        int ij;
        static int[] depx = new int[] { -2, -2, -1, -1, 1, 1, 2, 2 };
        static int[] depy = new int[] { -1, 1, -2, 2, -2, 2, -1, 1 };
        ButtonJ JoueurCavalier;

        int nombreCoup = 1;
        public Jeu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "FENETRE JEU";
            this.BackColor = Color.Fuchsia;
            this.Size = new Size(1000, 1000);
            for (int x = 0; x < 12; x++)
            {
            for (int y = 0; y < 12; y++)
            {
            Echiquier[x, y] = new ButtonJ(x, y);
            if ((x >= 2 && x <= 9) && (y >= 2 && y <= 9))
            {
            Echiquier[x, y].Click += new EventHandler(this.ButtonClik);
            Echiquier[x, y].Visible = true;
            Echiquier[x, y].Size = new Size(69, 69);
            Echiquier[x, y].Location = new Point((x) * 70, ((y - 2) * 70) + 140);
            }
            else
            {
            Echiquier[x, y].Enabled = false;
            Echiquier[x, y].cliqué = true;
            Echiquier[x, y].Size = new Size(0, 0);
            Echiquier[x, y].Visible = false;
            }
            this.Controls.Add(this.Echiquier[x, y]);
            if ((x + y) % 2 != 0)
            Echiquier[x, y].BackColor = Color.Black;
             }
            }

        }
 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AleatoireBouton(object sender, EventArgs e)
        {
        if (nombreCoup >= 1)
        return;
        Random rd = new Random();
        ii = rd.Next(2, 9);
        ij = rd.Next(2, 9);
        Echiquier[ii, ij].BackColor = Color.Yellow;
        Echiquier[ii, ij].Text = "" + nombreCoup++;
        Echiquier[ii, ij].cliqué = true;
        ColorieEchiquier(Echiquier[ii, ij].x, Echiquier[ii, ij].y);
        button2.Enabled = false;
        }

        public void ColorieEchiquier(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                if (Echiquier[x + depx[i], y - depy[i]].cliqué == false)
                {
                    Echiquier[x + depx[i], y - depy[i]].BackColor = Color.Green;
                }
            }
        }

        private void ButtonClik(object sender, EventArgs e)
        {
        ButtonJ b = (ButtonJ)sender;
        if (nombreCoup == 1 || b.BackColor == Color.Green)
        {
        if (!b.cliqué)
        {
        if (nombreCoup == 1)
        { ii = b.x;  ij = b.y;}
        b.cliqué = true;
        JoueurCavalier = b;
        MajEchiquier();
        b.BackColor = Color.Blue;
        b.Text = "" + nombreCoup++;
        ColorieEchiquier(b.x, b.y);
        if (FinJeu() && Vainqeur() )
        {
        MessageBox.Show("Vous avez gagner","MESSAGE",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }
        else if(FinJeu())
        {
       MessageBox.Show("GAME OVER", "MESSAGE",
       MessageBoxButtons.OK,
       MessageBoxIcon.Warning,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
        }
        }
        else MessageBox.Show("Vous avez deja joué", "MESSAGE",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }
        else MessageBox.Show("Erreur Coups", "MESSAGE",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        public Boolean FinJeu()
        {
        {
        for (int i = 2; i <= 9; i++)
        {
        for (int j = 2; j <= 9; j++)
        {
        if (Echiquier[i, j].BackColor == Color.Green)
        {return false;}
        }
        }
        return true;
        }
        }

        public Boolean Vainqeur()
        {
        if (FinJeu()==true && nombreCoup >= 63)
        {
        return true;
        }
        else return false;
        }

        public void Rejouer()
        {
        ButtonJ max=Echiquier[2,2];
        JoueurCavalier=new ButtonJ(0,0);
        int t;
        int maximum = 0;
        for (int i = 2; i <= 9; i++)
        {
        for (int j = 2; j <= 9; j++)
        {
        if (Int32.TryParse(Echiquier[i, j].Text, out t)) {
        if (t >= maximum)
        {
         maximum = t;
         max = Echiquier[i, j];
        }
        }
        else;}
         }
        for (int i = 2; i <= 9; i++)
        {
        for (int j = 2; j <= 9; j++)
        {
        if (Int32.TryParse(Echiquier[i, j].Text, out t))
        {
        if (t == maximum - 1)
        JoueurCavalier = Echiquier[i, j];
        }
        }
        }
        max.cliqué = false;
        MajEchiquier();
        nombreCoup--;
        max.Text = "";
        ColorieEchiquier(JoueurCavalier.x, JoueurCavalier.y);
        }

        
        public void MajEchiquier()
        {
        for (int i = 2; i <= 9; i++)
        {
        for (int j = 2; j <= 9; j++)
        {
        if ((i + j) % 2 != 0 && Echiquier[i, j].cliqué == false)
        {
        Echiquier[i, j].BackColor = Color.Black;
        }
        else if ((i + j) % 2 == 0 && Echiquier[i, j].cliqué == false)
        Echiquier[i, j].BackColor = Color.White;
        else if (Echiquier[i, j].cliqué)
        Echiquier[i, j].BackColor = Color.Red;
        Echiquier[i, j].Image = null;
        }
        }
        JoueurCavalier.Image = Image.FromFile("images.bmp");
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreCoup > 2)
                Rejouer();
            else;
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
        if (!Vainqeur())
        {
        DialogResult reponse = MessageBox.Show(
        "Voulez vous lancer une simulation compléte  ?",
        "Fermeture",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.ServiceNotification);
        if (reponse == DialogResult.Yes)
        {
        Simulation s1 = new SimulationJeu(ii - 1, ij - 1);
        s1.Focus();
        s1.Show();
        }
        }
        }

        private void règlesDuJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
       MessageBox.Show("Le but de cette application graphique WinForms (C#), est de faire parcourir à un JoueurCavalier l'ensemble d'un échiquier sans passer deux fois sur la même case. On rappelle la technique de déplacement d'un JoueurCavalier sur un échiquier : à partir d'une case X, un JoueurCavalier peut se déplacer sur l'une des 8 cases suivantes", "MESSAGE",
       MessageBoxButtons.OK,
       MessageBoxIcon.Warning,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        MessageBox.Show("Cette application a été créer par David Halioua et Emmnanuel ELbaz", "MESSAGE",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

    


