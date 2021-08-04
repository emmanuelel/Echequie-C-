namespace WindowsFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSimu = new System.Windows.Forms.Button();
            this.JeuButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSimu
            // 
            this.buttonSimu.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSimu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSimu.Location = new System.Drawing.Point(385, 290);
            this.buttonSimu.Name = "buttonSimu";
            this.buttonSimu.Size = new System.Drawing.Size(212, 94);
            this.buttonSimu.TabIndex = 0;
            this.buttonSimu.Text = "Simulation";
            this.buttonSimu.UseVisualStyleBackColor = false;
            this.buttonSimu.Click += new System.EventHandler(this.buttonSimu_Click);
            // 
            // JeuButton
            // 
            this.JeuButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.JeuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JeuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.JeuButton.Location = new System.Drawing.Point(151, 290);
            this.JeuButton.Name = "JeuButton";
            this.JeuButton.Size = new System.Drawing.Size(211, 94);
            this.JeuButton.TabIndex = 1;
            this.JeuButton.Text = "Jeu";
            this.JeuButton.UseVisualStyleBackColor = false;
            this.JeuButton.Click += new System.EventHandler(this.JeuButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(726, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JeuButton);
            this.Controls.Add(this.buttonSimu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSimu;
        private System.Windows.Forms.Button JeuButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

