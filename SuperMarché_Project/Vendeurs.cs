using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarché_Project
{
    public partial class Vendeurs : Form
    {
        Functions Con;

        public Vendeurs()
        {
            InitializeComponent();
            Con = new Functions();
            ListerVendeurs();
        }

        private void ListerVendeurs()
        {
            string Req = "Select * from VendeurTBl";
            VendeursListe.DataSource = Con.recupereData(Req);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Vendeur_Load(object sender, EventArgs e)
        {

        }
        //Btn Enregistrer
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PeudoTb.Text == "" || MotDePasseTb.Text == "" || AdresseTb.Text == "" || PhoneTb.Text == "")
                {
                    MessageBox.Show("Complter le formulaire Svp!!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Pseudo = PeudoTb.Text;
                    string Mpasse = MotDePasseTb.Text;
                    string Adresse = AdresseTb.Text;
                    string Phone = PhoneTb.Text;

                    string Req = "insert into VendeurTBl values ('{0}','{1}','{2}','{3}','{4}')";
                    Req = string.Format(Req, Nom, Pseudo, Mpasse, Phone, Adresse);
                    Con.recupereData(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur Ajouté !!!");
                    NomTb.Text = "";
                    PeudoTb.Text = "";
                    MotDePasseTb.Text = "";
                    AdresseTb.Text = "";
                    PhoneTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void VendeursListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NomTb.Text = VendeursListe.SelectedRows[0].Cells[1].Value.ToString();
                PeudoTb.Text = VendeursListe.SelectedRows[0].Cells[2].Value.ToString();
                MotDePasseTb.Text = VendeursListe.SelectedRows[0].Cells[3].Value.ToString();
                PhoneTb.Text = VendeursListe.SelectedRows[0].Cells[4].Value.ToString();
                AdresseTb.Text = VendeursListe.SelectedRows[0].Cells[5].Value.ToString();
                if (NomTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(VendeursListe.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No row is currently selected.");
            }

        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Sélectioner un Vendeur Svp!!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Pseudo = PeudoTb.Text;
                    string Mpasse = MotDePasseTb.Text;
                    string Adresse = AdresseTb.Text;
                    string Phone = PhoneTb.Text;

                    string Req = "Delete from VendeurTBl where VendCode ={0} ";
                    Req = string.Format(Req, Key);
                    Con.recupereData(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur Supprimer !!!");
                    NomTb.Text = "";
                    PeudoTb.Text = "";
                    MotDePasseTb.Text = "";
                    AdresseTb.Text = "";
                    PhoneTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        

        private void DeconnexionBtn_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdresseTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PeudoTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MotDePasseTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Articles1 Obj = new Articles1();
            Obj.Show();
            this.Hide();


        }

       

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Vendeurs Obj = new Vendeurs();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Factures Obj = new Factures();
            Obj.Show();
            this.Hide();
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PeudoTb.Text == "" || MotDePasseTb.Text == "" || AdresseTb.Text == "" || PhoneTb.Text == "")
                {
                    MessageBox.Show("Complter le formulaire Svp!!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Pseudo = PeudoTb.Text;
                    string Mpasse = MotDePasseTb.Text;
                    string Adresse = AdresseTb.Text;
                    string Phone = PhoneTb.Text;

                    string Req = "update  VendeurTBl set VendNom ='{0}',VendPseudo ='{1}', VendPass ='{2}', VendPhone ='{3}', VendAdd='{4}' where VendCode = {5}";
                    Req = string.Format(Req, Nom, Pseudo, Mpasse, Phone, Adresse, Key);
                    Con.recupereData(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur Modifier !!!");
                    NomTb.Text = "";
                    PeudoTb.Text = "";
                    MotDePasseTb.Text = "";
                    AdresseTb.Text = "";
                    PhoneTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Vendeurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'superMarcheBDDataSet.VendeurTBl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vendeurTBlTableAdapter.Fill(this.superMarcheBDDataSet.VendeurTBl);

        }

        private void NomTb_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void VendeursListe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}