using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public partial class SimulationJeu : Simulation
    {
        public SimulationJeu(int x , int y) : base()
        {
            getAleatoireButton().Enabled = false;
            getAbsTextBox().Text = x.ToString();
            getOrdTextBox().Text = y.ToString();

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1070, 749);
            this.Name = "SimulationJeu";
            this.Load += new System.EventHandler(this.SimulationJeu_Load);
            this.ResumeLayout(false);

        }

        private void SimulationJeu_Load(object sender, EventArgs e)
        {

        }
    }
}
