using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Simulation : Form
    {
    Button[,] Echiquier;
    static int[,] echec = new int[12, 12];
    static int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
    static int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
    int nb_fuite, min_fuite, lmin_fuite = 0;
    int i, j, k, l, ii, jj, NombrePasRadio;
    System.Timers.Timer aTimer;
        
    private void PositionCavalier(object sender, EventArgs e)
    {
    RedemarerCavalier(sender, e);
    k = 1;
    bool ValeurTexte = Int32.TryParse(AbsTextbox.Text, out ii);

    if (ValeurTexte && ii >= 1 && ii <= 8)
    ii = Int32.Parse(AbsTextbox.Text);

    else
    {
    MessageBox.Show(
    "Entrer une valeur comprise entre 1 et 8 dans " + AbsLabel.Text,
    "Attention",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning,
    MessageBoxDefaultButton.Button1,
    MessageBoxOptions.DefaultDesktopOnly);
    ii = 0;
    AbsTextbox.Text = null;
    return;
    }
    ValeurTexte = Int32.TryParse(OrdTextbox.Text, out jj);
    if (ValeurTexte && jj >= 1 && jj <= 8)
    jj = Int32.Parse(OrdTextbox.Text);

    else
    {
    MessageBox.Show(
    "Entrer une valeur comprise entre 1 et 8 dans " + OrdLabel.Text, 
    "Attention",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning,
    MessageBoxDefaultButton.Button1,
    MessageBoxOptions.DefaultDesktopOnly);
    jj = 0;
    OrdTextbox.Text = null;
    return;
    }
    for (i = 0; i < 12; i++)
    for (j = 0; j < 12; j++)
    echec[i, j] = ((i < 2 | i > 9 | j < 2 | j > 9) ? -1 : 0);
    i = ii + 1; j = jj + 1;
    echec[i, j] = 1;
    Echiquier[i - 2, j - 2].BackColor = Color.Red;
    Echiquier[i - 2, j - 2].Text = "1";
    Echiquier[i-2, j-2].Image = Image.FromFile("images.bmp");
    AvancerBouton.Enabled = true;
    PauseBouton.Enabled = false;
    ReculerBouton.Enabled = true;
        }
    private void LancerCavalier(object sender, EventArgs e)
    {
     aTimer.Interval = VitTrackbar.Value * 1000;
     aTimer.Enabled = true;
    PauseBouton.Enabled = true;
    AvancerBouton.Enabled = false;
     ReculerBouton.Enabled = false;
    RenitialiserBouton.Enabled = false;
        }
        private void ReculerCavalier(object sender, EventArgs e)
        {
            if (k == 1)
            {
                return;
            }
            int NombrePas;
            if (radioPasFull.Checked == true)
                NombrePas = 1;
            else NombrePas = 0;
            for (; NombrePas < NombrePasRadio; ++NombrePas)
            {
            for (int l = 0; l < 8; l++)
            for (int c = 0; c < 8; c++)
            {
            if (Echiquier[l, c].Text == k.ToString())
            {
            Echiquier[l, c].Text = null;
            if (c % 2 == 0)
            if (l % 2 == 0)
            Echiquier[l, c].BackColor = Color.Black;
            else Echiquier[l, c].BackColor = Color.White;
            else
            if (l % 2 == 0)
            Echiquier[l, c].BackColor = Color.White;
            else Echiquier[l, c].BackColor = Color.Black;
            }
                }
            --k;
            echec[i, j] = 0;
            for (int l = 0; l < 8; l++)
            for (int c = 0; c < 8; c++)
            if (Echiquier[l, c].Text == k.ToString())
            {
            i = l + 2;
            j = c + 2;
            }
            BalayageCavalier(i - 2, j - 2);
            }
        }

        private void BalayageCavalier(int i, int j)
        {
        for (int l = 0; l < 8; l++)
        for (int c = 0; c < 8; c++)
        Echiquier[l, c].Image = null;
        Echiquier[i, j].Image = Image.FromFile("images.bmp");
        }

        private void RejouerCavalier(object sender, EventArgs e)
        {
        RedemarerCavalier(sender, e);
        PositionCavalier(sender, e);
        LancerCavalier(sender, e);
        }

        private void StopCavalier(object sender, EventArgs e)
        {
        aTimer.Stop();
        PauseBouton.Enabled = false;
        AvancerBouton.Enabled = true;
        ReculerBouton.Enabled = true;
        RenitialiserBouton.Enabled = true;
        }

        public Simulation()
        {
        InitializeComponent();
        this.Echiquier = new Button[8, 8];
        aTimer = new System.Timers.Timer();
        aTimer.Elapsed += new ElapsedEventHandler(AvancerCavalier);
        AvancerBouton.Enabled = false;
        ReculerBouton.Enabled = false;
        PauseBouton.Enabled = false;   
        radio1Pas.Checked = true;
        NombrePasRadio = 1;
        char lettre = '1';
        for (int i = 0, lx = 105; i < 8; ++i, lx += 83)
        {
        Label l = new Label();
        l.Size = new Size(24, 25);
        l.Font = new Font("Century Gothic", 15);
        l.Text = lettre.ToString();
        l.Location = new System.Drawing.Point(lx, 38);
        ++lettre;
        this.Controls.Add(l);
        }
        lettre = '1';
        for (int i = 0, ly = 103; i < 8; ++i, ly += 83)
         {

        Label l = new Label();
        l.Size = new Size(24, 25);
        l.Font = new Font("Century Gothic", 15);
        l.Text = lettre.ToString();
        l.Location = new System.Drawing.Point(38, ly);
        ++lettre;
        this.Controls.Add(l);
            }
        for (int l = 0; l < 8; l++)
        for (int c = 0; c < 8; c++)
        {
        Button b;
        b = new Button();
        Echiquier[l, c] = b;
        b.Location = new System.Drawing.Point(75 + l * 83, 75 + c * 83);
                    
        if (c % 2 == 0)
        if (l % 2 == 0)
        b.BackColor = Color.Black;
        else b.BackColor = Color.White;
        
        else
        if (l % 2 == 0)
        b.BackColor = Color.White;
        else 
        b.BackColor = Color.Black;
                   
        b.Size = new System.Drawing.Size(83, 83);
                    
        b.Enabled = false;
                   
        this.Controls.Add(b);
                }
        }

        public  Simulation(int x, int y ) : base()
        {
        InitializeComponent();
        AbsTextbox.Text = x.ToString();
        OrdTextbox.Text = y.ToString();
        AbsTextbox.Enabled = false;
        }


        static int fuite(int i, int j)
        {
        int n, l;
        for (l = 0, n = 8; l < 8; l++)
        if (echec[i + depi[l], j + depj[l]] != 0) n--;
        return (n == 0) ? 9 : n;
        }

        private void VitLabel_Click(object sender, EventArgs e)
        {

        }

        private void AbsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Simulation_Load(object sender, EventArgs e)
        {
        label1.Text = "Entrer une valeur";    
        this.BackColor = Color.Fuchsia;
        this.Text = "FENETRE SIMULATION";
        }

        private void RedemarerCavalier(object sender, EventArgs e)
        {
        for (int l = 0; l < 8; l++)
        for (int c = 0; c < 8; c++)
        {
        Echiquier[l, c].Image = null;
        Echiquier[l, c].Text = null;
        if (c % 2 == 0)
        if (l % 2 == 0)
        Echiquier[l, c].BackColor = Color.Black;
        else Echiquier[l, c].BackColor = Color.White;
        else
        if (l % 2 == 0)
        Echiquier[l, c].BackColor = Color.White;
        else Echiquier[l, c].BackColor = Color.Black;
                }
        AvancerBouton.Enabled = false;
        ReculerBouton.Enabled = false;
        PauseBouton.Enabled = false;
            
            ii = 0; jj = 0;
        }

        private void AleatoireCavalier(object sender, EventArgs e)
        {
            Random random = new Random();
            AbsTextbox.Text = random.Next(1, 8).ToString();
            OrdTextbox.Text = random.Next(1, 8).ToString();
        }
        
        private void AvancerCavalier(object sender, EventArgs e)
        {
            if (k == 0)
            {
                MessageBox.Show(
                "Replacer le cavalier",
                "Attention",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
               
                return;
            }
            for (int NombrePas = 0; NombrePas < NombrePasRadio; ++NombrePas)
            {
                if (k == 64)
                {
                    aTimer.Stop();
                    RenitialiserBouton.Enabled = true;
                   
                    return;
                }
                ++k;
                for (l = 0, min_fuite = 11; l < 8; l++)
                {
                    ii = i + depi[l]; jj = j + depj[l];

                    nb_fuite = ((echec[ii, jj] != 0) ? 10 : fuite(ii, jj));

                    if (nb_fuite < min_fuite)
                    {
                        min_fuite = nb_fuite; lmin_fuite = l;
                    }
                }
                i += depi[lmin_fuite]; j += depj[lmin_fuite];
                echec[i, j] = k;
                Echiquier[i - 2, j - 2].BackColor = Color.Red;
                Echiquier[i - 2, j - 2].Text = k.ToString();
                BalayageCavalier(i - 2, j - 2);
            }
        }
        public Button getAleatoireButton()
        {
            return this.AleatoireBouton;
        }
        public TextBox getOrdTextBox()
        {
            return this.OrdTextbox;
        }

        public TextBox getAbsTextBox()
        {
            return this.AbsTextbox;
        }
        private void radioPasMAJ(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton RB = (RadioButton)sender;

                if (RB.Text == "1 pas")
                    NombrePasRadio = 1;
                else if (RB.Text == "5 pas")
                    NombrePasRadio = 5;
                else NombrePasRadio = 64;
            }
        }



        
        

        
    }
}
