namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur;
        Personnage monstre;

        public Form1()
        {
            InitializeComponent();
            joueur = new Personnage();
            joueur.PointDeVieMaximum = 10;
            joueur.PointDeVie = 10;
            joueur.PuissanceAttaque = 1;
            monstre = new Personnage();
            monstre.PointDeVieMaximum = 30;
            monstre.PointDeVie = 30;
            monstre.PuissanceAttaque = 3;

            ActualiserAffichage();
        }

        

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            monstre.PointDeVie -= joueur.PuissanceAttaque;
            joueur.PointDeVie -= monstre.PuissanceAttaque;

            ActualiserAffichage();
            if (joueur.EstMort)
            {
                MessageBox.Show("Vous êtes mort");
            }

            if (monstre.EstMort)
            {
                MessageBox.Show("Vous avez vaincus le Dragon");
            }
            
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointDeVie += 5;
            joueur.PointDeVie -= monstre.PuissanceAttaque;

            ActualiserAffichage();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PuissanceAttaque += 4;
            joueur.PointDeVie -= monstre.PuissanceAttaque;

            ActualiserAffichage();

            if (joueur.EstMort)
            {
                MessageBox.Show("Vous êtes mort");
            }
        }

        private void ActualiserAffichage()
        {
            lbl_pointsVieJoueur.Text = $"Points de vie: {joueur.PointDeVie}";
            lbl_pointsVieDragon.Text = $"Points de vie {monstre.PointDeVie}";

            lbl_puissanceAttaqueJoueur.Text = $"Puissance d'attaque: {joueur.PuissanceAttaque}";
            lbl_puissanceAttaqueDragon.Text = $"Puissance d'attaque: {monstre.PuissanceAttaque}";
        }
    }
}