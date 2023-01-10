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
    public partial class Categories : Form
    {
        Functions Con;
        public Categories()
        {
            InitializeComponent();
            Con = new Functions();
            ListerCategories();
        }

        private void ListerCategories()
        {
            string Req = "Select * from CategorieTbl";
            CategoriesListe.DataSource = Con.recupereData(Req);
        }
        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(NomCatTb.Text == "" || RemTb.Text == "")
                { MessageBox.Show("Completer le formulaire svp !!"); }
                else
                { 
                    string Nom=NomCatTb.Text;
                    string Rem = RemTb.Text;
                    string Req = "insert into CategorieTbl values('{0}','{1}')";
                    Req= string.Format(Req, Nom, Rem);  
                    Con.envoyerData(Req);
                    ListerCategories();
                    MessageBox.Show("Categorie ajoutée avec success");
                    NomCatTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        int key = 0;
        private void CategoriesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomCatTb.Text = CategoriesListe.SelectedRows[0].Cells[1].Value.ToString();
            RemTb.Text = CategoriesListe.SelectedRows[0].Cells[2].Value.ToString();
            if (NomCatTb.Text=="")
            { key = 0; }
            else
            {
                key = Convert.ToInt32(CategoriesListe.SelectedRows[0].Cells[0].Value.ToString());
            }
            

        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomCatTb.Text == "" || RemTb.Text == "")
                { MessageBox.Show("Completer le formulaire svp !!"); }
                else
                {
                    string Nom = NomCatTb.Text;
                    string Rem = RemTb.Text;
                    string Req = "update CategorieTbl set NomCat='{0}',RemarqCat='{1}' where CodeCat={2}";
                    Req = string.Format(Req, Nom, Rem, key);
                    Con.envoyerData(Req);
                    ListerCategories();
                    MessageBox.Show("Categorie updated !! ");
                    NomCatTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomCatTb.Text == "" || RemTb.Text == "")
                { MessageBox.Show("Completer le formulaire svp !!"); }
                else
                {
                    string Nom = NomCatTb.Text;
                    string Rem = RemTb.Text;
                    string Req = "delete from CategorieTbl where CodeCat={0}";
                    Req = string.Format(Req,key);
                    Con.envoyerData(Req);
                    ListerCategories();
                    MessageBox.Show("Categorie deleted !! ");
                    NomCatTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void DeconnexionBtn_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Articles1 Obj = new Articles1();
            Obj.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vendeurs Obj = new Vendeurs();
            Obj.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factures Obj = new Factures();
            Obj.Show();
            this.Hide();
        }
    }
}
