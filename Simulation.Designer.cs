namespace WindowsFormsApp1
{
    partial class Simulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RenitialiserBouton = new System.Windows.Forms.Button();
            this.Lentlabel = new System.Windows.Forms.Label();
            this.RapLabel = new System.Windows.Forms.Label();
            this.PauseBouton = new System.Windows.Forms.Button();
            this.VitTrackbar = new System.Windows.Forms.TrackBar();
            this.VitLabel = new System.Windows.Forms.Label();
            this.radioPasFull = new System.Windows.Forms.RadioButton();
            this.radio5Pas = new System.Windows.Forms.RadioButton();
            this.radio1Pas = new System.Windows.Forms.RadioButton();
            this.nbMouvLabel = new System.Windows.Forms.Label();
            this.PlacerBouton = new System.Windows.Forms.Button();
            this.AleatoireBouton = new System.Windows.Forms.Button();
            this.OrdLabel = new System.Windows.Forms.Label();
            this.AbsLabel = new System.Windows.Forms.Label();
            this.OrdTextbox = new System.Windows.Forms.TextBox();
            this.AbsTextbox = new System.Windows.Forms.TextBox();
            this.ReculerBouton = new System.Windows.Forms.Button();
            this.AvancerBouton = new System.Windows.Forms.Button();
            this.RejouerBouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VitTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // RenitialiserBouton
            // 
            this.RenitialiserBouton.BackColor = System.Drawing.Color.MidnightBlue;
            this.RenitialiserBouton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenitialiserBouton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RenitialiserBouton.Location = new System.Drawing.Point(826, 218);
            this.RenitialiserBouton.Name = "RenitialiserBouton";
            this.RenitialiserBouton.Size = new System.Drawing.Size(106, 43);
            this.RenitialiserBouton.TabIndex = 1;
            this.RenitialiserBouton.Text = "Renitialiser";
            this.RenitialiserBouton.UseVisualStyleBackColor = false;
            this.RenitialiserBouton.Click += new System.EventHandler(this.RedemarerCavalier);
            // 
            // Lentlabel
            // 
            this.Lentlabel.AutoSize = true;
            this.Lentlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lentlabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lentlabel.Location = new System.Drawing.Point(1000, 334);
            this.Lentlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lentlabel.Name = "Lentlabel";
            this.Lentlabel.Size = new System.Drawing.Size(46, 16);
            this.Lentlabel.TabIndex = 13;
            this.Lentlabel.Text = "10 sec";
            // 
            // RapLabel
            // 
            this.RapLabel.AutoSize = true;
            this.RapLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RapLabel.Location = new System.Drawing.Point(862, 334);
            this.RapLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RapLabel.Name = "RapLabel";
            this.RapLabel.Size = new System.Drawing.Size(39, 16);
            this.RapLabel.TabIndex = 12;
            this.RapLabel.Text = "1 sec";
            // 
            // PauseBouton
            // 
            this.PauseBouton.BackColor = System.Drawing.Color.MidnightBlue;
            this.PauseBouton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBouton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PauseBouton.Location = new System.Drawing.Point(826, 373);
            this.PauseBouton.Margin = new System.Windows.Forms.Padding(2);
            this.PauseBouton.Name = "PauseBouton";
            this.PauseBouton.Size = new System.Drawing.Size(232, 35);
            this.PauseBouton.TabIndex = 10;
            this.PauseBouton.Text = "Pause";
            this.PauseBouton.UseVisualStyleBackColor = false;
            this.PauseBouton.Click += new System.EventHandler(this.StopCavalier);
            // 
            // VitTrackbar
            // 
            this.VitTrackbar.Location = new System.Drawing.Point(865, 305);
            this.VitTrackbar.Margin = new System.Windows.Forms.Padding(2);
            this.VitTrackbar.Minimum = 1;
            this.VitTrackbar.Name = "VitTrackbar";
            this.VitTrackbar.Size = new System.Drawing.Size(181, 45);
            this.VitTrackbar.TabIndex = 9;
            this.VitTrackbar.Value = 1;
            // 
            // VitLabel
            // 
            this.VitLabel.AutoSize = true;
            this.VitLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VitLabel.Location = new System.Drawing.Point(926, 287);
            this.VitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VitLabel.Name = "VitLabel";
            this.VitLabel.Size = new System.Drawing.Size(48, 16);
            this.VitLabel.TabIndex = 6;
            this.VitLabel.Text = "Vitesse";
            this.VitLabel.Click += new System.EventHandler(this.VitLabel_Click);
            // 
            // radioPasFull
            // 
            this.radioPasFull.AutoSize = true;
            this.radioPasFull.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPasFull.Location = new System.Drawing.Point(988, 193);
            this.radioPasFull.Margin = new System.Windows.Forms.Padding(2);
            this.radioPasFull.Name = "radioPasFull";
            this.radioPasFull.Size = new System.Drawing.Size(52, 20);
            this.radioPasFull.TabIndex = 18;
            this.radioPasFull.TabStop = true;
            this.radioPasFull.Text = "Max";
            this.radioPasFull.UseVisualStyleBackColor = true;
            this.radioPasFull.CheckedChanged += new System.EventHandler(this.radioPasMAJ);
            // 
            // radio5Pas
            // 
            this.radio5Pas.AutoSize = true;
            this.radio5Pas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio5Pas.Location = new System.Drawing.Point(911, 193);
            this.radio5Pas.Margin = new System.Windows.Forms.Padding(2);
            this.radio5Pas.Name = "radio5Pas";
            this.radio5Pas.Size = new System.Drawing.Size(36, 20);
            this.radio5Pas.TabIndex = 17;
            this.radio5Pas.TabStop = true;
            this.radio5Pas.Text = "5 ";
            this.radio5Pas.UseVisualStyleBackColor = true;
            this.radio5Pas.CheckedChanged += new System.EventHandler(this.radioPasMAJ);
            // 
            // radio1Pas
            // 
            this.radio1Pas.AutoSize = true;
            this.radio1Pas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1Pas.Location = new System.Drawing.Point(837, 193);
            this.radio1Pas.Margin = new System.Windows.Forms.Padding(2);
            this.radio1Pas.Name = "radio1Pas";
            this.radio1Pas.Size = new System.Drawing.Size(33, 20);
            this.radio1Pas.TabIndex = 16;
            this.radio1Pas.TabStop = true;
            this.radio1Pas.Text = "1";
            this.radio1Pas.UseVisualStyleBackColor = true;
            this.radio1Pas.CheckedChanged += new System.EventHandler(this.radioPasMAJ);
            // 
            // nbMouvLabel
            // 
            this.nbMouvLabel.AutoSize = true;
            this.nbMouvLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbMouvLabel.Location = new System.Drawing.Point(873, 172);
            this.nbMouvLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nbMouvLabel.Name = "nbMouvLabel";
            this.nbMouvLabel.Size = new System.Drawing.Size(142, 19);
            this.nbMouvLabel.TabIndex = 15;
            this.nbMouvLabel.Text = "Nombre de pas : ";
            // 
            // PlacerBouton
            // 
            this.PlacerBouton.BackColor = System.Drawing.Color.MidnightBlue;
            this.PlacerBouton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlacerBouton.Location = new System.Drawing.Point(825, 110);
            this.PlacerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.PlacerBouton.Name = "PlacerBouton";
            this.PlacerBouton.Size = new System.Drawing.Size(232, 38);
            this.PlacerBouton.TabIndex = 11;
            this.PlacerBouton.Text = "Placer";
            this.PlacerBouton.UseVisualStyleBackColor = false;
            this.PlacerBouton.Click += new System.EventHandler(this.PositionCavalier);
            // 
            // AleatoireBouton
            // 
            this.AleatoireBouton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AleatoireBouton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AleatoireBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AleatoireBouton.Location = new System.Drawing.Point(824, 67);
            this.AleatoireBouton.Margin = new System.Windows.Forms.Padding(2);
            this.AleatoireBouton.Name = "AleatoireBouton";
            this.AleatoireBouton.Size = new System.Drawing.Size(233, 39);
            this.AleatoireBouton.TabIndex = 8;
            this.AleatoireBouton.Text = "Aléatoirement";
            this.AleatoireBouton.UseVisualStyleBackColor = false;
            this.AleatoireBouton.Click += new System.EventHandler(this.AleatoireCavalier);
            // 
            // OrdLabel
            // 
            this.OrdLabel.AutoSize = true;
            this.OrdLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdLabel.Location = new System.Drawing.Point(971, 49);
            this.OrdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrdLabel.Name = "OrdLabel";
            this.OrdLabel.Size = new System.Drawing.Size(44, 16);
            this.OrdLabel.TabIndex = 5;
            this.OrdLabel.Text = "Lignes";
            // 
            // AbsLabel
            // 
            this.AbsLabel.AutoSize = true;
            this.AbsLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsLabel.Location = new System.Drawing.Point(823, 49);
            this.AbsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AbsLabel.Name = "AbsLabel";
            this.AbsLabel.Size = new System.Drawing.Size(58, 16);
            this.AbsLabel.TabIndex = 4;
            this.AbsLabel.Text = "Colonne";
            this.AbsLabel.Click += new System.EventHandler(this.AbsLabel_Click);
            // 
            // OrdTextbox
            // 
            this.OrdTextbox.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdTextbox.Location = new System.Drawing.Point(988, 25);
            this.OrdTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdTextbox.Name = "OrdTextbox";
            this.OrdTextbox.Size = new System.Drawing.Size(23, 22);
            this.OrdTextbox.TabIndex = 2;
            this.OrdTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AbsTextbox
            // 
            this.AbsTextbox.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsTextbox.Location = new System.Drawing.Point(837, 25);
            this.AbsTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.AbsTextbox.Name = "AbsTextbox";
            this.AbsTextbox.Size = new System.Drawing.Size(23, 22);
            this.AbsTextbox.TabIndex = 1;
            this.AbsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReculerBouton
            // 
            this.ReculerBouton.BackColor = System.Drawing.Color.MidnightBlue;
            this.ReculerBouton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReculerBouton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReculerBouton.Location = new System.Drawing.Point(826, 563);
            this.ReculerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.ReculerBouton.Name = "ReculerBouton";
            this.ReculerBouton.Size = new System.Drawing.Size(233, 98);
            this.ReculerBouton.TabIndex = 1;
            this.ReculerBouton.Text = "Reculer";
            this.ReculerBouton.UseVisualStyleBackColor = false;
            this.ReculerBouton.Click += new System.EventHandler(this.ReculerCavalier);
            // 
            // AvancerBouton
            // 
            this.AvancerBouton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AvancerBouton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvancerBouton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AvancerBouton.Location = new System.Drawing.Point(826, 443);
            this.AvancerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.AvancerBouton.Name = "AvancerBouton";
            this.AvancerBouton.Size = new System.Drawing.Size(233, 99);
            this.AvancerBouton.TabIndex = 0;
            this.AvancerBouton.Text = "Avancer";
            this.AvancerBouton.UseVisualStyleBackColor = false;
            this.AvancerBouton.Click += new System.EventHandler(this.AvancerCavalier);
            // 
            // RejouerBouton
            // 
            this.RejouerBouton.BackColor = System.Drawing.Color.MidnightBlue;
            this.RejouerBouton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejouerBouton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RejouerBouton.Location = new System.Drawing.Point(959, 218);
            this.RejouerBouton.Margin = new System.Windows.Forms.Padding(2);
            this.RejouerBouton.Name = "RejouerBouton";
            this.RejouerBouton.Size = new System.Drawing.Size(100, 43);
            this.RejouerBouton.TabIndex = 20;
            this.RejouerBouton.Text = "Rejouer";
            this.RejouerBouton.UseVisualStyleBackColor = false;
            this.RejouerBouton.Click += new System.EventHandler(this.RejouerCavalier);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Magenta;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(862, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RejouerBouton);
            this.Controls.Add(this.Lentlabel);
            this.Controls.Add(this.RenitialiserBouton);
            this.Controls.Add(this.radioPasFull);
            this.Controls.Add(this.radio1Pas);
            this.Controls.Add(this.radio5Pas);
            this.Controls.Add(this.AbsTextbox);
            this.Controls.Add(this.OrdTextbox);
            this.Controls.Add(this.PlacerBouton);
            this.Controls.Add(this.RapLabel);
            this.Controls.Add(this.nbMouvLabel);
            this.Controls.Add(this.AleatoireBouton);
            this.Controls.Add(this.AvancerBouton);
            this.Controls.Add(this.ReculerBouton);
            this.Controls.Add(this.VitTrackbar);
            this.Controls.Add(this.AbsLabel);
            this.Controls.Add(this.OrdLabel);
            this.Controls.Add(this.PauseBouton);
            this.Controls.Add(this.VitLabel);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VitTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RenitialiserBouton;
        private System.Windows.Forms.Button AleatoireBouton;
        private System.Windows.Forms.Label VitLabel;
        private System.Windows.Forms.Label OrdLabel;
        private System.Windows.Forms.Label AbsLabel;
        private System.Windows.Forms.TextBox OrdTextbox;
        private System.Windows.Forms.TextBox AbsTextbox;
        private System.Windows.Forms.Button PauseBouton;
        private System.Windows.Forms.TrackBar VitTrackbar;
        private System.Windows.Forms.Button ReculerBouton;
        private System.Windows.Forms.Button AvancerBouton;
        private System.Windows.Forms.Button PlacerBouton;
        private System.Windows.Forms.Label Lentlabel;
        private System.Windows.Forms.Label RapLabel;
        private System.Windows.Forms.Label nbMouvLabel;
        private System.Windows.Forms.RadioButton radioPasFull;
        private System.Windows.Forms.RadioButton radio5Pas;
        private System.Windows.Forms.RadioButton radio1Pas;
        private System.Windows.Forms.Button RejouerBouton;
        private System.Windows.Forms.Label label1;
    }
}