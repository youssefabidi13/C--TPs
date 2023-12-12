namespace Exercice3TP5
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
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

        private void InitializeComponent()
        {
            this.couleursAffichage = new System.Windows.Forms.CheckBox();
            this.quit = new System.Windows.Forms.Button();
            this.couleurs = new System.Windows.Forms.GroupBox();
            this.buttonBleu = new System.Windows.Forms.RadioButton();
            this.buttonRouge = new System.Windows.Forms.RadioButton();
            this.buttonVert = new System.Windows.Forms.RadioButton();
            this.couleurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayColors
            // 
            this.couleursAffichage.AutoSize = true;
            this.couleursAffichage.Location = new System.Drawing.Point(67, 66);
            this.couleursAffichage.Name = "displayColors";
            this.couleursAffichage.Size = new System.Drawing.Size(164, 24);
            this.couleursAffichage.TabIndex = 0;
            this.couleursAffichage.Text = "Afficher les couleurs";
            this.couleursAffichage.UseVisualStyleBackColor = true;
            this.couleursAffichage.CheckedChanged += new System.EventHandler(this.afficherColor_changeDisplay);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(561, 66);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(94, 29);
            this.quit.TabIndex = 1;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // colors
            // 
            this.couleurs.Controls.Add(this.buttonBleu);
            this.couleurs.Controls.Add(this.buttonRouge);
            this.couleurs.Controls.Add(this.buttonVert);
            this.couleurs.Location = new System.Drawing.Point(67, 205);
            this.couleurs.Name = "colors";
            this.couleurs.Size = new System.Drawing.Size(611, 164);
            this.couleurs.TabIndex = 2;
            this.couleurs.TabStop = false;
            this.couleurs.Text = "Coleurs";
            this.couleurs.Visible = false;
            // 
            // rdBtnBlue
            // 
            this.buttonBleu.AutoSize = true;
            this.buttonBleu.Location = new System.Drawing.Point(332, 77);
            this.buttonBleu.Name = "rdBtnBlue";
            this.buttonBleu.Size = new System.Drawing.Size(59, 24);
            this.buttonBleu.TabIndex = 2;
            this.buttonBleu.TabStop = true;
            this.buttonBleu.Text = "Blue";
            this.buttonBleu.UseVisualStyleBackColor = true;
            this.buttonBleu.CheckedChanged += new System.EventHandler(this.rdBtnBlue_CheckedChanged);
            // 
            // rdBtnRed
            // 
            this.buttonRouge.AutoSize = true;
            this.buttonRouge.Location = new System.Drawing.Point(167, 73);
            this.buttonRouge.Name = "rdBtnRed";
            this.buttonRouge.Size = new System.Drawing.Size(73, 24);
            this.buttonRouge.TabIndex = 1;
            this.buttonRouge.TabStop = true;
            this.buttonRouge.Text = "Rouge";
            this.buttonRouge.UseVisualStyleBackColor = true;
            this.buttonRouge.CheckedChanged += new System.EventHandler(this.rdBtnRed_CheckedChanged);
            // 
            // rdBtnGreen
            // 
            this.buttonVert.AutoSize = true;
            this.buttonVert.Location = new System.Drawing.Point(23, 73);
            this.buttonVert.Name = "rdBtnGreen";
            this.buttonVert.Size = new System.Drawing.Size(56, 24);
            this.buttonVert.TabIndex = 0;
            this.buttonVert.TabStop = true;
            this.buttonVert.Text = "Vert";
            this.buttonVert.UseVisualStyleBackColor = true;
            this.buttonVert.CheckedChanged += new System.EventHandler(this.rdBtnGreen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.couleurs);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.couleursAffichage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.couleurs.ResumeLayout(false);
            this.couleurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox couleursAffichage;
        private Button quit;
        private GroupBox couleurs;
        private RadioButton buttonVert;
        private RadioButton buttonBleu;
        private RadioButton buttonRouge;
    }
}
