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
    public partial class Menu : Form
    {
        public Menu()
        {
        InitializeComponent();
        pictureBox1.Image = Image.FromFile("Resources/echec.png");
            
        }

        private void buttonSimu_Click(object sender, EventArgs e)
        {
        Simulation FS = new Simulation();
        FS.Show();
        }

        private void JeuButton_Click(object sender, EventArgs e)
        {
        Jeu FJ = new Jeu();
        FJ.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        label1.Text = "BIENVENUE SUR LE JEU CAVALIER D'EULER";
        this.Text = "ECHIQUIER HALIOUA & ELBAZ ";
        }
    }
}
