namespace Exercice3TP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Interdire à l’utilisateur de redimensionner l’interface manuellement.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        //Lorsque la case « Afficher les couleurs » est cochée, la deuxième partie de l’applications’affiche
        private void afficherColor_changeDisplay(object sender, EventArgs e)
        {
            if (couleursAffichage.Checked)
            {
                couleurs.Visible = true;

            }
            else
            {
                couleurs.Visible = false;
            }
        }
        // changer la couleur de l’arrière-plan du formulaire change selon la couleur choisie.
        private void rdBtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonVert.Checked) this.BackColor = Color.Green;
        }

        private void rdBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonRouge.Checked) this.BackColor = Color.Red;
        }

        private void rdBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonBleu.Checked) this.BackColor = Color.Blue;
        }

        //Le bouton « Quitter » permet de quitter l’application
        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
